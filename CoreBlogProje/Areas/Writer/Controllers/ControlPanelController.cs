using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreBlogProje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/ControlPanel")]
    public class ControlPanelController : Controller
    {

        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        private readonly UserManager<WriterUser> _userManager;


        public ControlPanelController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();

        }
        [Route("")]
        [Route("WriterBlogList")]
        public IActionResult WriterBlogList(string user,int page=1)
        {
            user = User.Identity.Name;
            Context c = new Context();
            var values = c.Blogs.Include(b => b.Category).Where(p => p.WriterUser.UserName == user).ToPagedList(page,3);
            return View(values);
        }
        [Route("")]
        [Route("DeleteBlog/{id}")]
        public IActionResult DeleteBlog(int id)
        {
            var values = bm.GetById(id);
            bm.Remove(values);

            return RedirectToAction("WriterBlogList");
        }
        [HttpGet]
        [Route("")]
        [Route("EditBlog/{id}")]
        public IActionResult EditBlog(int id)
        {
            List<SelectListItem> BlogCategoryList = (from i in cm.GetList()
                                                     select new SelectListItem
                                                     {
                                                         Text = i.CategoryName,
                                                         Value = i.CategoryID.ToString()
                                                     }).ToList();
            ViewBag.BlogCategoryList = BlogCategoryList;
            var values = bm.GetById(id);
            return View(values);
        }
        [Route("")]
        [Route("EditBlog/{id}")]
        [HttpPost]
        public IActionResult EditBlog(Blog b)
        {
            bm.Update(b);
            return RedirectToAction("WriterBlogList");
        }
        [Route("")]
        [Route("AddBlog")]
        [HttpGet]
        public IActionResult AddBlog()
        {
            List<SelectListItem> BlogCategoryList = (from i in cm.GetList()
                                                     select new SelectListItem
                                                     {
                                                         Text = i.CategoryName,
                                                         Value = i.CategoryID.ToString()
                                                     }).ToList();
            ViewBag.BlogCategoryList = BlogCategoryList;
            return View();
        }
        [Route("")]
        [Route("AddBlog")]
        [HttpPost]
        public async Task<IActionResult> AddBlog(Blog b)
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
           
            b.WriterID=user.Id;
            bm.Add(b);
            return RedirectToAction("WriterBlogList");
        }
        [Route("")]
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            string user = User.Identity.Name;
            Context c = new Context();
            var tarih = DateTime.Now.Date;
            var tarih2 = DateTime.Now.AddDays(-7);
            var numberofblogsperweek = c.Blogs.Include(b => b.Category).Where(p => p.BlogCreateDate >= tarih2 && p.BlogCreateDate <= tarih).OrderByDescending(a => a.BlogID).Where(p => p.WriterUser.UserName == user).Count();
            var blogcount = c.Blogs.Where(p => p.WriterUser.UserName == user).Count();
            ViewBag.numberofblogsperweek = numberofblogsperweek;
            ViewBag.blogcount = blogcount;
            var usermail = c.Users.Where(p => p.UserName == user).Select(y => y.Email).FirstOrDefault();
            var todaymessagecount = c.WritersMessages.Where(p=>p.Date==tarih).OrderByDescending(p=>p.ID).Where(p => p.Receiver == usermail).Count();
            ViewBag.todaymessagecount = todaymessagecount;
            return View();
        }
    
    }
}

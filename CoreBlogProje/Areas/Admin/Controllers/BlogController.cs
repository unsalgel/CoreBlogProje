using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;

namespace CoreBlogProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("Admin/Blog")]
 
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
           var values=bm.AdminGetList();
            return View(values);
        }
        [Route("")]
        [Route("DeleteBlog/{id}")]
        public IActionResult DeleteBlog(int id)
        {
           var deleteblog=bm.GetById(id);
            bm.Remove(deleteblog);
            return RedirectToAction("Index");   
        }
        [Route("")]
        [Route("EditBlog/{id}")]
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            List<SelectListItem> BlogCategory = (from i in cm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = i.CategoryName,
                                                     Value = i.CategoryID.ToString()
                                                 }).ToList();
            ViewBag.blogcategory = BlogCategory;
            var values = bm.GetById(id);
            return View(values);
        }
        [Route("")]
        [Route("EditBlog/{id}")]
        [HttpPost]
        public IActionResult EditBlog(Blog b)
        {
            bm.Update(b);
            return RedirectToAction("Index");
        }
    }
}

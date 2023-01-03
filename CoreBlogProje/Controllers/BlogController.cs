using BusinessLayer.Concrete;
using CoreBlogProje.Models;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreBlogProje.Controllers
{
    
     
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
     

        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogDetails(int id)
        {
            var values = bm.GetBlogByID(id);          
            Context c = new Context();
            var val = c.Comments.Where(p => p.BlogID == id).Count();
            ViewBag.val = val;
            return View(values);
        }
        public PartialViewResult BlogDetailsSideBar()
        {
           
            return PartialView();
        }
     
    }



}


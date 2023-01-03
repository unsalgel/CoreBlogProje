using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace CoreBlogProje.Areas.ViewComponents.WriterWeeklyBlogs
{
    public class WriterWeeklyBlogs : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string user = User.Identity.Name;
            Context c = new Context();
            var tarih = DateTime.Now;   
            var tarih2 = DateTime.Now.AddDays(-7);
            var values = c.Blogs.Include(b=>b.Category).Where(p => p.BlogCreateDate >= tarih2 && p.BlogCreateDate <= tarih).OrderByDescending(a => a.BlogID).Where(p => p.WriterUser.UserName == user).ToList();
            return View(values);
        }
    }
}
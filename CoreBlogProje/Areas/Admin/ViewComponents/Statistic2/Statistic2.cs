using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreBlogProje.Areas.Admin.ViewComponents.Statistic2
{
    public class Statistic2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.recentlyblog = c.Blogs.OrderByDescending(p => p.BlogID).Select(y => y.BlogTitle).FirstOrDefault();
                return View();  
        }
    }
}

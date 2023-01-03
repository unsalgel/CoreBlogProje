using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProje.ViewComponents.Footer
{
    public class FooterLast3Post:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var value = bm.GetLast3Blog();
            return View(value);  
        }
    }
}

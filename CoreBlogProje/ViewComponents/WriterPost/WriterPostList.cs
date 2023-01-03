using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProje.ViewComponents.WriterPost
{
    public class WriterPostList:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int WriterID)
        {
    ;
            var value = bm.GetBlogListWriter(WriterID);
            return View(value);  
        }
    }
}

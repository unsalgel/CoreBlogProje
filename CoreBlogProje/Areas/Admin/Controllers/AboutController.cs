using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("Admin/About")]
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EfAboutRepository());
        [Route("")]
        [Route("EditAbout")]
        [HttpGet]
        public IActionResult EditAbout()
        {
            var values = am.GetById(9);
            return View(values);
        }
        [Route("")]
        [Route("EditAbout")]
        [HttpPost]
        public IActionResult EditAbout(About a)
        {
            am.Update(a);
            return View();
        }
    }
}

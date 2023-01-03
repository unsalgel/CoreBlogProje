using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("Admin/Announcements")]
    public class AnnouncementsController : Controller
    {
        AnnouncementsManager am = new AnnouncementsManager(new EfAnnouncementsRepository());

        [Route("")]
        [Route("Announcements")]
        public IActionResult Announcements()
        {
            var values = am.GetList();
            return View(values);
        }
        [Route("")]
        [Route("DeleteAnnouncements/{id}")]
        public IActionResult DeleteAnnouncements(int id)
        {
            var values = am.GetById(id);
            am.Remove(values);
            return RedirectToAction("Announcements");
        }
        [Route("")]
        [Route("AddAnnouncements")]
        public IActionResult AddAnnouncements(Announcements a)
        {
            am.Add(a);
            return RedirectToAction("Announcements");

        }
    }
}

using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Announcement")]

    public class AnnouncementController : Controller
    {

        AnnouncementsManager am = new AnnouncementsManager(new EfAnnouncementsRepository());

        [Route("")]
        [Route("AnnouncementDetails/{id}")]
        public IActionResult AnnouncementDetails(int id)
        {
            var values = am.GetById(id);    
            return View(values);
        }
    }
}

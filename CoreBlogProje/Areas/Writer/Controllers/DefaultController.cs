using CoreBlogProje.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreBlogProje.Areas.WriterArea.Controllers
{
     
    [Area("Writer")]
    [Route("Writer/Default")]
    public class DefaultController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DefaultController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            
            return View();
        }
        [Route("")]
        [Route("WriterNavbarPartial")]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        [Route("")]
        [Route("WriterSidebarPartial")]
        public  PartialViewResult WriterSidebarPartial()
        {
           
            return PartialView();
        }
    }
}

using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
	[Route("Admin/Contact")]
	public class ContactController : Controller
	{
        ContactBoxManager cm = new ContactBoxManager(new EfContactBoxRepository());

        [Route("")]
		[Route("ContactEdit")]
		[HttpGet]
		public IActionResult ContactEdit()
		{
			var values = cm.GetById(1);
			return View(values);
		}
        [Route("")]
        [Route("ContactEdit")]
        [HttpPost]
        public IActionResult ContactEdit(ContactBox c)
        {
			cm.Update(c);
			return View();
        }
    }
}

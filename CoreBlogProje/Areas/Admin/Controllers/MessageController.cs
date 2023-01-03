using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CoreBlogProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MessageController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}

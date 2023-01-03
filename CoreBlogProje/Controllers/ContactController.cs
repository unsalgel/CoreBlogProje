using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace CoreBlogProje.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        ContactBoxManager cmb = new ContactBoxManager(new EfContactBoxRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult ContactMaps()
        {
            var values = cmb.GetList();
            return PartialView(values);
        }


        public  IActionResult ContactAdd(Contact c)
        {
          
            c.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.ContactStatus = true;
            cm.Add(c);
            var values = JsonConvert.SerializeObject(c);

            return Json(values);
        }
    }
}

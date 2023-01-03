using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProje.ViewComponents.Contact
{
    public class ContactList:ViewComponent
    {
        ContactBoxManager cm = new ContactBoxManager(new EfContactBoxRepository());
        public IViewComponentResult Invoke()
        {
            var values=cm.GetList();
            return View(values);
        }
    }
}

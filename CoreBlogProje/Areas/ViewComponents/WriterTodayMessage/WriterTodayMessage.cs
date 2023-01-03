using BusinessLayer.Concrete;
using CoreBlogProje.Areas.Writer.Models;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProje.Areas.ViewComponents.WriterTodayMessage
{
    public class WriterTodayMessage : ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;
        WritersMessageManager wm = new WritersMessageManager(new EfWritersMessageRepository());
        public WriterTodayMessage(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string mail;
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            mail = values.Email;
            DateTime date = DateTime.Now.Date;
            Context c = new Context();
            var message = (from item in c.Users
                           join y in c.WritersMessages on item.Email equals y.Sender
                           where y.Receiver == mail
                           select new WriterImage
                           {
                               ImageUrl = item.ImageURL,
                               Date = y.Date,
                               SenderName = y.SenderName,
                               MessageContent = y.MessageContent,
                               ID = y.ID,
                               Receiver = y.Receiver
                           }).Where(a => a.Date == date).ToList();

            return View(message); 
        }
    }
}

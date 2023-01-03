﻿using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CoreBlogProje.Areas.ViewComponents.WriterNotification
{
    public class WriterNotificationList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var tarih = DateTime.Now.Date;
            var tarih2 = DateTime.Now.AddDays(7);
            var values = c.Announcements.Where(p=>p.Date>=tarih && p.Date<=tarih2).OrderByDescending(a=>a.ID).ToList();  
            return View(values);      
        }
    }
}

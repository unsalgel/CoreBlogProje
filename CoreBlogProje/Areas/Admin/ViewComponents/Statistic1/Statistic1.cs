using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreBlogProje.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var totalblog = bm.GetList().Count;
            ViewBag.totalblog=totalblog;
            //Apiden Hava durumu çekmek için
            string weatherapi = "15a16172122e64a3858d6f7d16c1531f";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=izmir&mode=xml&lang=tr&units=metric&appid=" + weatherapi;
            XDocument document = XDocument.Load(connection);
            ViewBag.weatherforecast = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();  
        }
    }
}

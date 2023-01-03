using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Text;
using System.Linq;
using System.Xml;

namespace CoreBlogProje.Areas.Admin.ViewComponents.Statistic3
{
    public class Statistic3 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {

            //toplam kullanıcı sayısını çektim
            var usercount = c.Users.Count();
            ViewBag.usercount = usercount;
            //toplam yorum sayısını çektim
            var commentcount = c.Comments.Count();  
            ViewBag.commentcount = commentcount;    
            //toplam kategori sayısını çektim
            var categorycount= c.Categories.Count();    
            ViewBag.categorycount = categorycount;
            //Dolar kurunu  çektim
            string exchangerate = "http://www.tcmb.gov.tr/kurlar/today.xml";
            XmlDocument xDocument = new XmlDocument();
            xDocument.Load(exchangerate);
            XmlNode XnDollar = xDocument.SelectSingleNode("/Tarih_Date/Currency/ForexSelling");
            ViewBag.xndollar = XnDollar.InnerText;


            return View();
        }
    }
}

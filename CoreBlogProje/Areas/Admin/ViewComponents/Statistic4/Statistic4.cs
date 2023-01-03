 
using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CoreBlogProje.Areas.Admin.ViewComponents.Statistic4
{
    public class Statistic4:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            Context c = new Context();
            //En çok yazı yazan yazarın ismini çektim
            var bestwritername = c.Blogs.Include(p => p.WriterUser).GroupBy(x => x.WriterUser.Name).OrderByDescending(y => y.Count()).Select(s => s.Key).FirstOrDefault();
            ViewBag.bestwritername= bestwritername;
            //En çok yazı yazan yazarın resmini çektim
            var bestwriterimg = c.Blogs.Include(x=>x.WriterUser).Where(p=>p.WriterUser.Name==bestwritername).Select(y=>y.WriterUser.ImageURL).FirstOrDefault();
            ViewBag.bestwriterimg = bestwriterimg;
            //En çok yazı yazan yazarın blog sayısını çektim
            var bestwriterblogcount = c.Blogs.Include(x => x.WriterUser).Where(p => p.WriterUser.Name == bestwritername).Count();
            ViewBag.bestwriterblogcount = bestwriterblogcount;
            //En çok yazı yazan yazarın mail adresini çektim
            var bestwriteremail = c.Blogs.Include(v => v.WriterUser).Where(p => p.WriterUser.Name == bestwritername).Select(t => t.WriterUser.Email).FirstOrDefault();
            ViewBag.bestwriteremail = bestwriteremail;
            var subscribemailcount=c.NewsLetters.Count();
            ViewBag.subscribemailcount= subscribemailcount;
            return View();  
        }
    }
}

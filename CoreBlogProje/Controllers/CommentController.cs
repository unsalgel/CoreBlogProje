using BusinessLayer.Concrete;
using CoreBlogProje.Models;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace CoreBlogProje.Controllers
{
	[AllowAnonymous]
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		BlogManager bm = new BlogManager(new EfBlogRepository());	
		public IActionResult Index()
		{
		
			return View();
		}
		
		[HttpGet]
        public IActionResult CommentAdd(int id)
        {
			var values = cm.GetById(id);
			return View(values);
        }
     
		public IActionResult CommentAdd(Comment c)
		{
			c.UserImage = "/web/images/resimyok.png";
			c.CommentStatus = true;
            cm.Add(c);
			var values = JsonConvert.SerializeObject(c);
			return Json(values);
		}
		
        public IActionResult CommentList(int BlogID)
        {
			
            var valueid = cm.GetCommentListALL(BlogID);
            var values = JsonConvert.SerializeObject(valueid);
		 
            return Json(values);

        }
 



    }
}

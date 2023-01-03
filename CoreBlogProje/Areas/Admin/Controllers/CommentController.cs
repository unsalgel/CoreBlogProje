using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("Admin/Comment")]

    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = cm.GetCommentList();
            return View(values);
        }
        //Yorumu Onayla
        [Route("")]
        [Route("CommentStatusTrue/{id}")]
        public IActionResult CommentStatusTrue(int id)
        {   
            Context c = new Context();
            var commentstatustrue = c.Comments.Find(id);
            commentstatustrue.CommentStatus = true;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //Yorumu Gizle
        [Route("")]
        [Route("CommentStatusFalse/{id}")]
        public IActionResult CommentStatusFalse(int id)
        {
            Context c = new Context();
            var commentstatustrue = c.Comments.Find(id);
            commentstatustrue.CommentStatus = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("")]
        [Route("DeleteComment/{id}")]
        public IActionResult DeleteComment(int id)
        {
            var deletecomment=cm.GetById(id);
            cm.Remove(deletecomment);
            return RedirectToAction("Index");
        }
    }
}

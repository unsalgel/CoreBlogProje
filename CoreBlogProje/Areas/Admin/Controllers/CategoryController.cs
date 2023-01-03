using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("Admin/Category")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        [Route("")]
        [Route("CategoryList")]
        public IActionResult CategoryList()
        {
          var categorylist=cm.GetList();
            return View(categorylist);
        }
        //kategori durumu aktifleştirme
        [Route("")]
        [Route("CategoryStatuTrue/{id}")]
        public IActionResult CategoryStatuTrue(int id)
        {
            Context c = new Context();
            var categorystatus = c.Categories.Find(id);
            categorystatus.CategoryStatus = true;
            c.SaveChanges();
            return RedirectToAction("CategoryList", new { Area = ("Admin") });
        }
        //kategori durumu pasifleştirme
        [Route("")]
        [Route("CategoryStatuFalse/{id}")]
        public IActionResult CategoryStatuFalse(int id)
        {
            Context c = new Context();
            var categorystatus = c.Categories.Find(id);
            categorystatus.CategoryStatus = false;
            c.SaveChanges();
            return RedirectToAction("CategoryList", new { Area = ("Admin") });
        }
        [Route("")]
        [Route("EditCategory/{id}")]
        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var values = cm.GetById(id);    
            return View(values);  
        }
        [HttpPost]
        [Route("")]
        [Route("EditCategory/{id}")]
        public IActionResult EditCategory(Category c)
        {
            cm.Update(c);
            return RedirectToAction("CategoryList", new { Area = ("Admin") });
        }
        [Route("")]
        [Route("AddCategory")]
        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            cm.Add(c);
            return RedirectToAction("CategoryList", new { Area = ("Admin") });
        }
    }
}

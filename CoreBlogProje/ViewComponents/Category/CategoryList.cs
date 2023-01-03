﻿using BusinessLayer.Concrete;

using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
 

namespace CoreBlogProje.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        { 
            var values = cm.CategoryList();
             return View(values);
        }
    }
}

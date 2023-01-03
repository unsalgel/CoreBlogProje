﻿using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace CoreBlogProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("Admin/UserList")]
    public class UserListController : Controller
    {
        readonly RoleManager<WriterRole> _roleManager;
        readonly UserManager<WriterUser> _userManager;
        WriterUserManager wm = new WriterUserManager(new EfWriterUserRepository());

        public UserListController(RoleManager<WriterRole> roleManager, UserManager<WriterUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [Route("")]
        [Route("UsersList")]
        public IActionResult UsersList(string search)
        {
            Context c = new Context();
            var values = from s in c.Users select s;
            if (!string.IsNullOrEmpty(search))
            {
                values = values.Where(a => a.Name.Contains(search));
            }
           // var values = wm.GetList();
            return View(values.ToList());
        }

        [Route("")]
        [Route("DeleteUser/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var values = wm.GetById(id);
            wm.Remove(values);
            return RedirectToAction("UsersList");
        }
 
    }
}

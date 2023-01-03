﻿using CoreBlogProje.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreBlogProje.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        private readonly SignInManager<WriterUser> _SignInManager;
 
        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _SignInManager = signInManager;
        }
        [HttpGet]   
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Index(UserLoginViewModel model)
        {
            var result = await _SignInManager.PasswordSignInAsync(model.UserName, model.Password, false, true);
             
            if (ModelState.IsValid)
            {
                if (result.Succeeded)
                {  
                
                   return RedirectToAction("Index", "Default", new { area = "Writer" });
                   
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _SignInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}

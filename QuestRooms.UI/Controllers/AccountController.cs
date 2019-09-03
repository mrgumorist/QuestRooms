using QuestRooms.UI.App_Start;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using QuestRooms.DAL.Entities;
using QuestRooms.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.UI.Controllers
{
    public class AccountController : Controller
    {
        private AppUserManager _userManager;
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        public AppUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserRegisterModel model)
        {
            AppUser user = new AppUser()
            {
                Email = model.Email,
                UserName = model.Email
            };
            var res = UserManager.Create(user, model.Password);
            if (res.Succeeded) return RedirectToAction("Index", "Rooms");
            foreach (var err in res.Errors)
                ModelState.AddModelError("", err);
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserRegisterModel model)
        {
            var user = UserManager.Find(model.Email, model.Password);
            if (user == null)
            {
                ModelState.AddModelError("", "User is not exists");
                return View();
            }
            ClaimsIdentity claim = UserManager.CreateIdentity(user,
                                    DefaultAuthenticationTypes.ApplicationCookie);
            AuthenticationManager.SignOut();
            AuthenticationManager.SignIn(new AuthenticationProperties
            {
                IsPersistent = true
            }, claim);
            return RedirectToAction("Index", "Rooms");
        }

        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Rooms");
        }
    }
}
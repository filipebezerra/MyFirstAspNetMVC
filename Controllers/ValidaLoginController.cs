using MyFirstAspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstAspNetMVC.Controllers
{
    public class ValidaLoginController : Controller
    {
        public ActionResult RegisterUser()
        {
            var user = new User();

            return View(user);
        }

        [HttpPost]
        public ActionResult RegisterUser(User user)
        {
            if (ModelState.IsValid)
            {
                return View("Result", user);
            }

            return View(user);
        }

        public ActionResult Result(User user)
        {
            return View(user);
        }
    }
}

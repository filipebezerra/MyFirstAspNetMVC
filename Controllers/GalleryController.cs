using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstAspNetMVC.Controllers
{
    public class GalleryController : Controller
    {
        public ActionResult GalleryView()
        {
            return View();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstAspNetMVC.Models;

namespace MyFirstAspNetMVC.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult ContactView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MyContacts(string name, string email, string cellPhone)
        {
            @ViewData["name"] = name;
            @ViewData["email"] = email;
            @ViewData["cellPhone"] = cellPhone;
            return View();
        }

        public ActionResult MyContactsTyped()
        {
            var contact = new Contact
            {
                name = "Eurodata",
                email = "email@eurodata.com.br",
                cellPhone = "62 82010125",
                reason = "Cursos de Profissionalização"
            };

            return View(contact);
        }
    }
}

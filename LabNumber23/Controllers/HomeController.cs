using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabNumber23.Models;

namespace LabNumber23.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewUserRegistration()
        {
            return View();
        }

        public ActionResult AddUser(User NewUser)
        {
            GC_CoffeeShopEntities ORM = new GC_CoffeeShopEntities();

            // Validation

            // send new user to DB
            ORM.Users.Add(NewUser);

            // save to DB (Sync)
            ORM.SaveChanges();

            return RedirectToAction("Index");

           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
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
        public ActionResult ProgLan()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult AddUser(UserInfo newUser)
        {
            // ToDo: validation!!!!!!

            if (ModelState.IsValid)
            {
                // ToDo: Send the data to the DB

                // confirmation, or maybe send to the Index page

                //ViewData["ConfMessage"] = "Thanks " + newUser.FirstName;

                ViewBag.ConfMessage = "Thanks " + newUser.FirstName;

                return View("Confirm");
            }

            else
            {
                return View("Error");
            }
        }

    


    }
}
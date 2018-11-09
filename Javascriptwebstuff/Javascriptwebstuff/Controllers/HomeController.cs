using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Javascriptwebstuff.Controllers
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
            ViewBag.Camille = "Camille is the best";

            return View();
        }
        public ActionResult Sucess()
        {
            return View();
        }
        public ActionResult SubmitEmail(string email)
        {
            //write email to the database
            //send suscribe
            //eventually but not yet
            //return a message to the user that their e-mail was submitted
            
            ViewBag.Confirm = $"{email} has been added to the database";
            ViewBag.Camille = "BOW DOWN TO CAMILLE MORTALS";
            return View("Contact");
            
        }
    }
}
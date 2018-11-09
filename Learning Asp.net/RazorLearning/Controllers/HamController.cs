using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorLearning.Controllers
{
    public class HamController : Controller
    {
        // GET: Ham
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Bacon()
        {
            return View();
        }
    }
    
}
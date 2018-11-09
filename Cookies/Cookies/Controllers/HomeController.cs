using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string Unit = "";
            string Temp = "";

            if (Request.Cookies["Unit"] == null)
            {
                Temp = "75";
            }
            else
            {
                Unit = Request.Cookies["Unit"].Value;
                if (Unit == "C")
                {
                    Temp = "25";
                }
                else
                {
                    Temp = "75";
                }
            }

            ViewBag.Temp = Temp + Unit;
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
        public ActionResult ChangeUnit(string Unit)
        {
            //1. get the data
            HttpCookie myCookie;
            if (Request.Cookies["Unit"] == null)
            {
                myCookie = new HttpCookie("Unit", "F");
            }
            else
            {
                myCookie = Request.Cookies["Unit"];

            }
            //Save data to the cookie
            myCookie.Value = Unit;
            myCookie.Expires = new DateTime(2020, 1, 1);

            Response.Cookies.Add(myCookie); // sends it back to the client
            return RedirectToAction("Index");

        }
        int Num = 0;
        public ActionResult Increment()
        {
            //get the data
            HttpCookie newCookie;
            if (Request.Cookies["Num"] == null)
            {
                newCookie = new HttpCookie("Num", "0");
                DateTime newDate = DateTime.Now.AddMonths(1);
                newCookie.Expires = new DateTime(newDate.Year, newDate.Month, newDate.Day);
            }
            else
            {
                newCookie = Request.Cookies["Num"];
                Num = int.Parse(Request.Cookies["Num"].Value);

            }
            Num++;
            newCookie.Value = Num.ToString();
            Response.Cookies.Add(newCookie);//send the cookie back to the client.
            ViewBag.Num = Num;
            return View("Contact");

        }
    }
}




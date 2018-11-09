using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningaboutModels.Models;

namespace LearningaboutModels.Controllers
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
        public ActionResult Product(Product p)
        {
            List<Product> outputs = GetProduct();
            ViewBag.Message = "This is you product page";
            return View(outputs);

        }
        public List<Product> GetProduct()
        {
            List<Product> product = new List<Product>();
            Product p = new Product("Squeegee", 3.50, "It lets us wipe off that water!");
            product.Add(p);
            p = new Product("Bucket", 7.99, "Holds Water");
            product.Add(p);
            p = new Product("Monkey Bread", 0, "Cinnamon delicious bread");
            product.Add(p);
            p = new Product("Cereal", 4, "It's whole wheat!");
            product.Add(p);
            p = new Product();
            p.Cost = 100;
            p.Description = "Hot bread";
            p.Name = "Fresh Bananana";

            product.Add(p);

            //How would we add in a new product, how would we do that?

            return product;
        }
    }
}
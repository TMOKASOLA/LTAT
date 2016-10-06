using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
       static ProductInformation information = new ProductInformation();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            information.addProduct();
            
            return View(information.myList);
        }
        public ActionResult Contacts()
        {
            return View("Contacts");
        }

    }
}
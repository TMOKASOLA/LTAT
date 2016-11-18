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
        Cart cart = new Cart();
        ProductModel[] prod = new ProductModel[50];
       static CartModel cartmod = new CartModel();
        static int recIndex = 0;

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
            return View();
        }
        public ActionResult ProductDetail(string Name)
        {
            ProductModel prod = null;

            prod = information.getProductInfo(Name);



            return View(prod);
        }

        public ActionResult About()
        {
            return View("About");
        }

        public ActionResult addCart(string Name)
        {
            //check if session exists
            //if not, create new cart in model
            //then store id of cart in session

            //check if session exist
            //if it does, get your cart from the list
        


            if (Session["cart"] == null)
            {
                Session["cart"] = cartmod;
            }

            List<Cart> items = Session["cart"] as List<Cart>;
           
            prod[recIndex] = information.getProductInfo(Name);
            

            cart.Name = prod[recIndex].Name;
            cart.Description = prod[recIndex].Description;
            cart.Price = prod[recIndex].Price;
            cart.Quantity = 1;

            cartmod.addToCart(cart);

            ViewBag.Cart = cartmod.cartInfo.Count();

        //    items.Add(cart);

            Session["cart"] = cartmod;
            recIndex++;

            return View("Products", information.myList);

            /*List<int> list = Session["list"] as List<int>;
            if (list == null)
            {
                list = new List<int>();
                list.AddRange(Enumerable.Range(1, 100));
                Session["list"] = list;
            }*/
        }

        public ActionResult showResults()
        {
            var list = Session["cart"] as CartModel;

          
            return View(list.cartInfo);
        }
    }
}
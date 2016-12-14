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
        double total = 0;
        // GET: Home
        public ActionResult Index()
        {


            return View();
        }
        public ActionResult Products()
        {
            information.addProduct();

            if (Session["NumItems"] != null)
            {
                ViewBag.Cart = Session["NumItems"].ToString();
            }

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
        //public string checkExist(Cart cart)
        //{
        //    string status = "";

        //    if (cartmod.cartInfo.Contains(cart))
        //    {
        //        cart.Quantity++;
        //        status = "found";
        //    }else
        //    {
        //        cart.Quantity = 1;
        //        status = "not found";
        //    }
        //    return status;
        //}

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

            prod[recIndex] = information.getProductInfo(Name);


            cart.Name = prod[recIndex].Name;
            cart.Description = prod[recIndex].Description;
            cart.Price = prod[recIndex].Price;

            if (cartmod.checkExist(cart.Description).Equals("not found") )
            {
                cart.Quantity = 1;
                cartmod.addToCart(cart);
            }

            Session["NumItems"] = cartmod.cartInfo.Count();
            ViewBag.Cart = Session["NumItems"].ToString();

            Session["cart"] = cartmod;
            recIndex++;

            var list = Session["cart"] as CartModel;
            return View("Products", information.myList);


        }

        public ActionResult showResults()
        {
            var list = Session["cart"] as CartModel;

         

            foreach (var item in list.cartInfo)
            {
                total = total+ (Convert.ToDouble(item.Price) * item.Quantity);
            }
            Session["total"] = total.ToString();

            @ViewBag.Total = Session["total"];

            return View(list.cartInfo);
        }

        
        public ActionResult RemoveItem(string Name)
        {
            var list = Session["cart"] as CartModel;

            int count = 0;
            int index = 0;
            foreach (var items in list.cartInfo)
            {
                if (items.Name==Name)
                {
                     index = count;
                   
                }
                count++;
            }

            list.cartInfo.RemoveAt(index);

            foreach (var items in list.cartInfo)
            {
                total = total + Convert.ToDouble(items.Price);
            }
           
            //Session["cart"] = cartmod;
            //list = Session["cart"] as CartModel;

            Session["cart"] = cartmod;
            Session["NumItems"] = cartmod.cartInfo.Count();

            Session["total"] = total;

            @ViewBag.Total = Session["total"];

            return View("showResults", list.cartInfo);
        }
    }
}
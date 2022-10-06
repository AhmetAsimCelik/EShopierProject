using BusinessLogicLayer;
using BusinessLogicLayer.Result;
using EShopier.Entities;
using EShopier.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShopier_Project.Controllers
{
    public class CartController : Controller
    {
        CartManager cm = new CartManager();
        ProManager pro = new ProManager();
        UserManager um = new UserManager();
        
        // GET: Cart
        public ActionResult Index(/*int id*/)
        {
            return View(GetCart());
        }
        public ActionResult AddToCart(int id)
        {
            User currentUser = Session["login"] as User;

           
           
            if (currentUser==null)
            {

                return View("Error");
            }
            else
            {
                var product = pro.GetProduct(id);
                if (product != null)
                {
                    GetCart().AddProduct(product, 1);
                }
                return RedirectToAction("Index");
                

            }
           
        }
        public ActionResult AddToCart2(int id,int quantity)
        {
            User currentUser = Session["login"] as User;

            if (currentUser == null)
            {
                return View("Error");
            }
            else
            {
                var product = pro.GetProduct(id);
                if (product != null)
                {
                    GetCart().AddProduct(product, quantity);
                }
                return RedirectToAction("Index");
            }

           
        }
        public ActionResult RemoveFromCart(int id)
        {
            var product = pro.GetProduct(id);
            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }
            return RedirectToAction("Index");
        }
        public CartModel GetCart()
        {
            var cart = (CartModel)Session["Cart"];
            if (cart == null)
            {
                cart=new CartModel();
                Session["Cart"]=cart;
            }
            return cart;
        }
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult ErrorForAdmin()
        {
            return View();
        }
        public ActionResult ClearCart()
        {
            
            GetCart().Clear();  
            return RedirectToAction("Index");
        }
        public PartialViewResult Summary()
        {

            
            return PartialView(GetCart());
        }
        public ActionResult CheckOut()
        {
            return View();
        }
        public ActionResult deneme()
        {
            return View();
        }
       

    }
}
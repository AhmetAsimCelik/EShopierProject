using BusinessLogicLayer;
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
        
        // GET: Cart
        public ActionResult Index(/*int id*/)
        {
            return View(GetCart());
        }
        public ActionResult AddToCart(int id)
        {
            var product = pro.GetProduct(id);
            if (product != null)
            {
                GetCart().AddProduct(product, 1);
            }
            return RedirectToAction("Index");
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
    }
}
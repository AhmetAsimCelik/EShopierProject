using BusinessLogicLayer;
using EShopier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShopier_Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ProManager pro = new ProManager();
       
        public ActionResult Index()
        {

            return View(pro.Productlist());
           
            
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult ProdutDetails()
        {
            return View();
        }
        public ActionResult ByCategory(int? id )
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            CatManager cm = new CatManager();
            Category cat = cm.GetCategorgetir(id.Value);

            if (cat == null)
            {
                return HttpNotFound();
            }

            return View("Index", cat.Product);
        }
        public ActionResult ByBrand(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            BrandManager bm = new BrandManager();
            Brand bra = bm.GetBrandgetir(id.Value);

            if (bra == null)
            {
                return HttpNotFound();
            }

            return View("Index", bra.Products);
        }

    }
}
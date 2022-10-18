using BusinessLogicLayer;
using BusinessLogicLayer.Result;
using Eshopier.DAL.Messages;
using EShopier.Entities;
using EShopier.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.Windows.Forms;

namespace EShopier_Project.Controllers
{
    public class HomeController : Controller
    {
        

        
        ProManager pro = new ProManager();
        UserManager um = new UserManager();
        CatManager cm = new CatManager();
        BrandManager bm = new BrandManager();
        CartManager cartm = new CartManager();
       
        public ActionResult Index(int sayfa = 1)
        {
            var list = pro.Productlist().ToPagedList(sayfa, 9);           
            return View(list); 
           
        }
    
        public ActionResult ByCategory(int? id )
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

           
            Category cat = cm.GetCategorgetir(id.Value);

            if (cat == null)
            {
                return HttpNotFound();
            }

            return View("Index", cat.Product.ToPagedList(1,100));
        }
        public ActionResult ByBrand(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

          
            Brand bra = bm.GetBrandgetir(id.Value);

            if (bra == null)
            {
                return HttpNotFound();
            }

            return View("Index", bra.Products.ToPagedList(1,100));
        }
      
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginUser model)
        {
            if (ModelState.IsValid)
            {
                BusinessLayerResult<User> res = um.UserLogin(model);

                if (res.Errors.Count > 0)
                {
                   
                    res.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                    return View(model);
                }
                
                Session["login"] = res.Result;
                return RedirectToAction("Index");
            }


            return View(model);


        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterUser model, HttpPostedFileBase ProfileImage)
        {
          
            if (ModelState.IsValid)
            {
              
                if (ProfileImage!=null)
                {
                    var dosyaadi = Path.GetFileName(ProfileImage.FileName);
                    var uzanti = Path.Combine(Server.MapPath("~/Content/images"), dosyaadi);
                    
                    ProfileImage.SaveAs(uzanti);
                    model.ProfileImage = dosyaadi;
                    
                }
                else
                {
                    model.ProfileImage = "bos-profil.png";
                }
                BusinessLayerResult<User> res = um.RegisterUser(model);
               
                if (res.Errors.Count > 0)
                {
                    res.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                    return View(model);
                }
               
                return RedirectToAction("Login");
            }

           
            return View(model);
           


        }
        public ActionResult Logout()
        {
            Session.Clear();

            return RedirectToAction("Index");
        }
       
        public ActionResult Contact()
        {

            return View();

        }

        public ActionResult MostExpensive()
        {
            return View("Index", pro.Productlist().OrderByDescending(x => x.UnitPrice).ToList().ToPagedList(1,9));
        }
        public ActionResult MostCheap()
        {
            return View("Index", pro.Productlist().OrderBy(x => x.UnitPrice).ToList().ToPagedList(1,9));
        }
       




    }
}
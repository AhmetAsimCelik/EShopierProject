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

namespace EShopier_Project.Controllers
{
    public class HomeController : Controller
    {
        

        // GET: Home
        ProManager pro = new ProManager();
        UserManager um = new UserManager();
        CatManager cm = new CatManager();
        BrandManager bm = new BrandManager();  
       
        public ActionResult Index()
        {

            return View(pro.Productlist());
                     
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

            return View("Index", cat.Product);
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

            return View("Index", bra.Products);
        }
      
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginUser model)
        {
            //if (ModelState.IsValid)
            //{
            //    um.UserLogin(model);
            //}
            BusinessLayerResult<User> res = um.UserLogin(model);

            if (res.Errors.Count > 0)
            {
                if (res.Errors.Find(x => x.Code == ErrorMessageCode.UserIsNotActive) != null)
                {
                    ViewBag.SetLink = "http://Home/UserActivate";
                }

                res.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                return View(model);
            }

            Session["login"] = res.Result;    
            return RedirectToAction("Index"); 

            
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
                if (ProfileImage.ContentLength > 0)
                {
                    var dosyaadi = Path.GetFileName(ProfileImage.FileName);
                    var uzanti = Path.Combine(Server.MapPath("~/Content/images"), dosyaadi);
                    
                    ProfileImage.SaveAs(uzanti);
                    model.ProfileImage = dosyaadi;
                    
                }
                if (model.Password == model.PasswordAgain)
                {
                    um.UserRegister(model);
                }
                else
                {
                    return View();
                }
            }

            return RedirectToAction("Login");

        }
        public ActionResult Logout()
        {
            Session.Clear();

            return RedirectToAction("Index");
        }
        public ActionResult Cart()
        {

            return View();

        }
        public ActionResult Account()
        {
            User currentUser = Session["login"] as User;

            BusinessLayerResult<User> res = um.GetUserById(currentUser.ID);

            if (res.Errors.Count > 0)
            {
                
                return View("Error");
            }

            return View(res.Result);
         

        }
        public ActionResult AccountDelete()
        {

            return View();

        }
        [HttpPost]
        public ActionResult AccountDelete(User model)
        {
            um.DeleteUser(model);
            Session.Clear();
            return RedirectToAction("Index");
                      
        }
        public ActionResult AccountEdit()
        {

            return View();

        }
        public ActionResult Contact()
        {

            return View();

        }

    }
}
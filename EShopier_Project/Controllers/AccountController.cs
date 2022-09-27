using BusinessLogicLayer;
using BusinessLogicLayer.Result;
using EShopier.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShopier_Project.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        UserManager um = new UserManager();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowAccount()
        {
            User currentUser = Session["login"] as User;

            BusinessLayerResult<User> res = um.GetUserById(currentUser.ID);

            if (res.Errors.Count > 0)
            {

                return View("Error");
            }

            return View(res.Result);


        }
        [HttpPost]
        public ActionResult ShowAccount(User model ,HttpPostedFileBase ProfileImage)
        {
            var dosyaadi = Path.GetFileName(ProfileImage.FileName);
            var uzanti = Path.Combine(Server.MapPath("~/Content/images"), dosyaadi);


            ProfileImage.SaveAs(uzanti);
            model.ProfileImage = dosyaadi;
            BusinessLayerResult<User> res = um.EditUser(model);
            um.EditUser(model);
            Session["login"] = res.Result;
            return RedirectToAction("ShowAccount");


        }
        public ActionResult AccountDelete()
        {
            User currentUser = Session["login"] as User;

            BusinessLayerResult<User> res = um.GetUserById(currentUser.ID);

            if (res.Errors.Count > 0)
            {

                return View("Error");
            }

            return View(res.Result);
          

        }

        [HttpPost]      
        public ActionResult AccountDelete(User model)
        {
            um.DeleteUser(model);
            Session.Clear();
            return RedirectToAction("Index" , "Home");

        }
        public ActionResult AccountEdit()
        {
            User currentUser = Session["login"] as User;

            BusinessLayerResult<User> res = um.GetUserById(currentUser.ID);

            if (res.Errors.Count > 0)
            {

                return View("Error");
            }

            return View(res.Result);
          
        }
        [HttpPost]
        public ActionResult AccountEdit(User model, HttpPostedFileBase ProfileImage)
        {
            if (ProfileImage != null)
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
            BusinessLayerResult<User> res = um.EditUser(model);
          
            Session["login"] = res.Result; 

            return RedirectToAction("ShowAccount");
        }

    }
}
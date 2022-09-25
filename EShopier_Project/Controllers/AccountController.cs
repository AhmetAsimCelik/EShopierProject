using BusinessLogicLayer;
using BusinessLogicLayer.Result;
using EShopier.Entities;
using System;
using System.Collections.Generic;
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
        public ActionResult AccountEdit(User model)
        {
            BusinessLayerResult<User> res = um.EditUser(model);

            um.EditUser(model);
            //Session.Clear();
            Session["login"] = res.Result; 

            return RedirectToAction("ShowAccount");
        }

    }
}
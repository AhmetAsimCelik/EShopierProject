﻿using BusinessLogicLayer.Result;
using Eshopier.DAL;
using Eshopier.DAL.Messages;
using EShopier.Entities;
using EShopier.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UserManager
    {
       public Repository<User> _user = new Repository<User>();

        public BusinessLayerResult<User> RegisterUser(RegisterUser data)
        {
            User u = _user.Find(x => x.UserName == data.UserName || x.Email == data.Email);
            BusinessLayerResult<User> result = new BusinessLayerResult<User>();
            if (u != null)
            {
                if (u.UserName == data.UserName)
                {
                    result.AddError(ErrorMessageCode.UsernameAlreadyExists, "Kayıtlı kullanıcı adı");

                }
                if (u.Email == data.Email)
                {
                    result.AddError(ErrorMessageCode.EmailAlreadyExists, "Kayıtlı email adresi");
                }
                if (data.Password != data.Password)
                {
                    result.AddError(ErrorMessageCode.NotSamePassword, "Girdiğiniz Şifreler Uyuşmuyor");
                }
            }
            else
            {
                int dbresult = _user.Instert(new User()
                {
                    UserName = data.UserName,
                    Name = data.Name,
                    Email = data.Email,
                    Password = data.Password,
                    LastName = data.LastName


                });

            }
            return result;
        }

        public void UserRegister(RegisterUser model)
        {        

            _user.Instert(new User
            {
                UserName = model.UserName,
                Name = model.Name,
                LastName = model.LastName,
                Password = model.Password,
                Email = model.Email,
            });
        }
        public void UserLogin(LoginUser model)
        {
             var sonuc = _user.Find(x => x.UserName == model.UserName || x.Password == model.Password);
            if (sonuc != null)
            {

            }
            
            

        }



        //public void UserRegister(User model)
        //{
        //    user.Instert(model);

        //}


    }
}
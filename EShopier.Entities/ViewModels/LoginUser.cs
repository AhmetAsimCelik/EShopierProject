﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopier.Entities.ViewModels
{
    public class LoginUser
    {
        [DisplayName("Kullanıcı Adı"), Required(ErrorMessage = "! {0} alanı boş geçilemez.")]
        public string UserName { get; set; }

        [DisplayName("Şifre"), Required(ErrorMessage = "! {0} alanı boş geçilemez."), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

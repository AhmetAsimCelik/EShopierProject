﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopier.Entities.ViewModels
{
    public class RegisterUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
        public string PasswordAgain { get; set; }

        public string Email { get; set; }

        public string ProfileImage { get; set; }

    }
}

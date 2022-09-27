using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopier.Entities.ViewModels
{
    public class RegisterUser
    {
        [DisplayName("Ad"),Required(ErrorMessage = "! {0} alanı boş geçilemez.")]
        public string Name { get; set; }

        [DisplayName("Soyad"), Required(ErrorMessage = "! {0} alanı boş geçilemez.")]
        public string LastName { get; set; }

        [DisplayName("Kullanıcı Adı"), Required(ErrorMessage = "! {0} alanı boş geçilemez.")]
        public string UserName { get; set; }

        [DisplayName("Şifre"), Required(ErrorMessage = "! {0} alanı boş geçilemez."), DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Şifre Tekrar"), Required(ErrorMessage = "! {0} alanı boş geçilemez."), DataType(DataType.Password), Compare("Password", ErrorMessage = "! Girdiğiniz şifreler uyuşmuyor.")]
        public string PasswordAgain { get; set; }

        [DisplayName("Email"), Required(ErrorMessage = "! {0} alanı boş geçilemez."), EmailAddress(ErrorMessage = "{0} alanı için geçerli bir mail adresi giriniz.")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string ProfileImage { get; set; }

    }
}

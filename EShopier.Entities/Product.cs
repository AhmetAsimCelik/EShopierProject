using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopier.Entities
{
    public class Product
    {
        public int ID { get; set; }
        [Required,DisplayName("Ürün Adı")]

        public string Name { get; set; }
        [Required,DisplayName("Fiyat")]

        public int UnitPrice { get; set; }
        [Required, DisplayName("Stok")]

        public int UnitStock { get; set; }
        [DisplayName("MarkaID")]

        public int BrandID { get; set; }
        [DisplayName("MarkaID")]

        public Brand Brand { get; set; }
        [DisplayName("KategoriID")]

        public int CategoryID { get; set; }
        [DisplayName("KategoriID")]

        public Category Category { get; set; }
        [DisplayName("Kayıt Tarihi")]

        public DateTime AddDate { get; set; }
        [DisplayName("Ürün Fotoğrafı")]
        public string ProfileImage { get; set; }

       

    }
}

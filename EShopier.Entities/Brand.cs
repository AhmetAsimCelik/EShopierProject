using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopier.Entities
{
    public class Brand
    {
        public int ID { get; set; }
        [Required, DisplayName("Marka Adı")]
        public string Name { get; set; }
        [Required, DisplayName("Menşei")]

        public string Origin { get; set; }      
        public virtual List<Product> Products { get; set; }
        [DisplayName("Kayıt Tarihi")]

        public DateTime AddDate { get; set; }
        [DisplayName("Marka Fotoğrafı")]
        public string ProfileImage { get; set; }
        [DisplayName("Kuruluş Tarihi")]

        public int FoundationYear { get; set; }
        [Required, DisplayName("Açıklama")]

        public string Description { get; set; }



        public Brand()
        {
            Products = new List<Product>();

        }

    }
}

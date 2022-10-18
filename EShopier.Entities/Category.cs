using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopier.Entities
{
    public class Category
    {
        public int ID { get; set; }
        [Required, DisplayName("Kategori Adı")]

        public string Name { get; set; }
        [Required, DisplayName("Açıklama")]

        public string Description { get; set; }        
        public virtual List<Product> Product { get; set; }
        [DisplayName("Kayıt Tarihi")]

        public DateTime AddDate { get; set; }

        public Category()
        {
            Product = new List<Product>();

        }


    }
}

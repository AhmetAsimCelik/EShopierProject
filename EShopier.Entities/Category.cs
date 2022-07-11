using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopier.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }        
        public virtual List<Product> Product { get; set; }
        public virtual List<Brand> Brands { get; set; }
        public DateTime AddDate { get; set; }

        public Category()
        {
            Product = new List<Product>();
            //Brands = new List<Brand>();

        }


    }
}

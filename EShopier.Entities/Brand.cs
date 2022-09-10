using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopier.Entities
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }      
        public virtual List<Product> Products { get; set; }
        public DateTime AddDate { get; set; }
        public Brand()
        {
            Products = new List<Product>();

        }

    }
}

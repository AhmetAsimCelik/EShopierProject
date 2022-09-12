using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopier.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UnitPrice { get; set; }

        public string UnitStock { get; set; }

        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public DateTime AddDate { get; set; }

        public string ProfileImage { get; set; }

    }
}

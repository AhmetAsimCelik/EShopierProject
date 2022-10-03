using Eshopier.DAL;
using EShopier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ProManager
    {
        Repository<Product> product = new Repository<Product>();

        public List<Product> Productlist()
        {
            return product.List();
            
        }
        public Product GetProduct(int id)
        {
            return product.Find(c => c.ID == id);
        }
    }
}

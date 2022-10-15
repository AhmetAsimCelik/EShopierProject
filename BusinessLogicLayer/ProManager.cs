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
        public Product FindProduct(Product model)
        {
            var fınd = product.Find(x => x.ID == model.ID);

            if (model.ProfileImage == null)
            {
                model.ProfileImage = fınd.ProfileImage;

            }

            return fınd;
        }
        public virtual IQueryable<Product> ListQueryable()
        {
            return product.ListQueryable();
        }
    }
}

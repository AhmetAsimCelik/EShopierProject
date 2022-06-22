using Eshopier.DAL;
using EShopier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BrandManager
    {
        Repository<Brand> brand = new Repository<Brand>();

        public List<Brand> BrandList()
        {
            return brand.List();
        }
        public Brand GetBrandgetir(int id)
        {
            return brand.Find(c => c.ID == id);
        }
    }
}

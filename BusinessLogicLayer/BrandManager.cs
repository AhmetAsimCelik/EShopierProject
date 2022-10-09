using Eshopier.DAL;
using EShopier.Entities;
using EShopier.Entities.ViewModels;
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
        public Brand FindBrand(Brand model)
        {
            var fınd = brand.Find(x => x.ID == model.ID);

            if (model.ProfileImage == null)
            {
                model.ProfileImage = fınd.ProfileImage;

            }

            return fınd;
        }

    }
}

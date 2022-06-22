using Eshopier.DAL;
using EShopier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CatManager
    {
        Repository<Category> category = new Repository<Category>();

        public List<Category> CategoryList()
        {
            return category.List();
        }
        public Category GetCategorgetir(int id)
        {
            return category.Find(c => c.ID == id);
        }
    }
}

using EShopier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshopier.DAL
{
    internal class İnitializer : CreateDatabaseIfNotExists<Context>
    {
       
        protected override void Seed(Context context)
        {
            Category cat = new Category();
            for (int i = 0; i < 10; i++)
            {
                cat.Name = FakeData.NameData.GetMaleFirstName();
                cat.Description = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(1, 5));
                cat.AddDate = DateTime.Now;

                context.Categories.Add(cat);

                for (int b = 0; b < 10; b++)
                {
                    Brand brand = new Brand()
                    {
                        Name = FakeData.NameData.GetCompanyName(),
                        Origin = FakeData.PlaceData.GetCountry(),
                        AddDate = DateTime.Now,



                    };
                    cat.Brands.Add(brand);

                    for (int c = 0; c < 10; c++)
                    {
                        Product product = new Product()
                        {
                            Name = FakeData.NameData.GetFirstName(),
                            UnitPrice = FakeData.NumberData.GetNumber(100, 1000).ToString(),
                            UnitStock = FakeData.NumberData.GetNumber(1, 9).ToString(),
                            AddDate = DateTime.Now,

                        };
                        brand.Products.Add(product);

                    }

                }
                

            }
            context.SaveChanges();
        }
    }

}

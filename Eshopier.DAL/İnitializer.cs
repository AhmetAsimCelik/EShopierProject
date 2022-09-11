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
           

           for (int i = 0; i < 10; i++)
           {
                    Category cat = new Category();

                    cat.Name = FakeData.NameData.GetMaleFirstName();
                    cat.Description = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(1, 5));
                    cat.AddDate = DateTime.Now;

                    context.Categories.Add(cat);

                Brand brand = new Brand();
                Product product = new Product();

                for (int d = 0; d < 10; d++)
                {
                    
                    brand.Name = FakeData.NameData.GetCompanyName();
                    brand.Origin = FakeData.PlaceData.GetCountry();
                    brand.AddDate = DateTime.Now;

                    for (int b = 0; b < 10; b++)
                    {

                       
                        {
                            product.Name = FakeData.NameData.GetFirstName();
                            product.UnitPrice = FakeData.NumberData.GetNumber(100, 1000).ToString();
                            product.UnitStock = FakeData.NumberData.GetNumber(1, 9).ToString();
                            product.AddDate = DateTime.Now;

                        };

                        cat.Product.Add(product);
                        brand.Products.Add(product);

                    }
                }
                context.SaveChanges();
           }
           for (int i = 0; i < 10; i++)
           {
                User user = new User()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    LastName = FakeData.NameData.GetSurname(),
                    UserName = FakeData.NameData.GetFullName(),
                    Email = FakeData.NetworkData.GetEmail(),
                    Password = "1",
                    IsAdmin = false,
                    
                };

           }





        }
    }

}

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


            //for (int i = 0; i < 10; i++)
            //{
            //         Category cat = new Category();

            //         cat.Name = FakeData.NameData.GetMaleFirstName();
            //         cat.Description = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(1, 5));
            //         cat.AddDate = DateTime.Now;

            //         context.Categories.Add(cat);

            //     Brand brand = new Brand();
            //     Product product = new Product();

            //     for (int d = 0; d < 10; d++)
            //     {

            //         brand.Name = FakeData.NameData.GetCompanyName();
            //         brand.Origin = FakeData.PlaceData.GetCountry();
            //         brand.AddDate = DateTime.Now;

            //         for (int b = 0; b < 10; b++)
            //         {


            //             {
            //                 product.Name = FakeData.NameData.GetFirstName();
            //                 product.UnitPrice = FakeData.NumberData.GetNumber(100, 1000).ToString();
            //                 product.UnitStock = FakeData.NumberData.GetNumber(1, 9).ToString();
            //                 product.AddDate = DateTime.Now;

            //             };

            //             cat.Product.Add(product);
            //             brand.Products.Add(product);

            //         }
            //     }
            //     context.SaveChanges();
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //     User user = new User()
            //     {
            //         Name = FakeData.NameData.GetFirstName(),
            //         LastName = FakeData.NameData.GetSurname(),
            //         UserName = FakeData.NameData.GetFullName(),
            //         Email = FakeData.NetworkData.GetEmail(),
            //         Password = "1",
            //         IsAdmin = false,

            //     };

            //}
            //for (int b = 0; b < 9; b++)
            //{
            //    Product product = new Product();
            //    Category category = new Category();
            //    Brand brand = new Brand();  
            //    {
            //        product.Name = FakeData.NameData.GetFirstName();
            //        product.UnitPrice = FakeData.NumberData.GetNumber(100, 10000).ToString();
            //        product.UnitStock = FakeData.NumberData.GetNumber(1, 9).ToString();
            //        product.AddDate = DateTime.Now;
            //        product.Category = category;
            //        product.Brand = brand;
            //        product.ProfileImage = "4.png";
            //        context.Products.Add(product);
            //        for (int c = 0; c < 5; c++)
            //        {

            //            category.Name = FakeData.NameData.GetFirstName();
            //            category.Description = "Açıklamasatırı";
            //            category.AddDate = DateTime.Now;
            //            category.Product.Add(product);
            //            context.Categories.Add(category);
            //        }
            //        for (int c = 0; c < 5; c++)
            //        {

            //            brand.Name = FakeData.NameData.GetFirstName();
            //            brand.Origin = FakeData.PlaceData.GetCountry();
            //            brand.AddDate = DateTime.Now;
            //            brand.Products.Add(product);
            //            context.Brands.Add(brand);
            //        }
            //    };
            //    context.SaveChanges();









            //}

           

            Category category1 = new Category();
            category1.Name = "Ayakkabı";
            category1.Description = "Açıklamasatırı";           
            category1.AddDate = DateTime.Now;
     
            context.Categories.Add(category1);

            Category category2 = new Category();
            category2.Name = "Giyim";
            category2.Description = "Açıklamasatırı";
            category2.AddDate = DateTime.Now;
                    
            context.Categories.Add(category2);

            Brand brand1 = new Brand();
            brand1.Name = "Nike";
            brand1.AddDate= DateTime.Now;
            brand1.Origin = "USA";
            
            context.Brands.Add(brand1);

            Brand brand2 = new Brand();
            brand2.Name = "Puma";
            brand2.AddDate = DateTime.Now;
            brand2.Origin = "Italy";         
              
            context.Brands.Add(brand2);

            //Product product1 = new Product();
            //product1.Name = "Airforce";
            //product1.ProfileImage = "4.png";
            //product1.AddDate = DateTime.Now;
            //product1.UnitPrice = "1500";
            //product1.UnitStock = "10";
            //context.Products.Add(product1);

            //Product product2 = new Product();
            //product2.Name = "Puma Roma";
            //product2.ProfileImage = "4.png";
            //product2.AddDate = DateTime.Now;
            //product2.UnitPrice = "1200";
            //product2.UnitStock = "10";
            //context.Products.Add(product2);


            Product product3 = new Product();
            product3.Name = "Kaban";
            product3.ProfileImage = "4.png";
            product3.AddDate = DateTime.Now;
            product3.UnitPrice = "1200";
            product3.UnitStock = "10";
            product3.BrandID = brand1.ID;
            context.Products.Add(product3);

            context.SaveChanges();
        }
    }

}

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
            


            Category giyim = new Category();
            giyim.Name = "Giyim";
            giyim.Description = "Açıklamasatırı";
            giyim.AddDate=DateTime.Now;           
            context.Categories.Add(giyim);

            Category telefon = new Category();
            telefon.Name = "Telefon";
            telefon.Description = "Açıklamasatırı";
            telefon.AddDate = DateTime.Now;
            context.Categories.Add(telefon);

            Category ayakkabı = new Category();
            ayakkabı.Name = "Ayakkabı";
            ayakkabı.Description = "Açıklamasatırı";
            ayakkabı.AddDate = DateTime.Now;            
            context.Categories.Add(ayakkabı);

            Category bilgisayar = new Category();
            bilgisayar.Name = "Bilgisayar";
            bilgisayar.Description = "Açıklamasatırı";
            bilgisayar.AddDate = DateTime.Now;
            context.Categories.Add(telefon);

            Category televizyon = new Category();
            televizyon.Name = "Televizyon";
            televizyon.Description = "Açıklamasatırı";
            televizyon.AddDate = DateTime.Now;
            context.Categories.Add(televizyon);

            Brand nike = new Brand();
            nike.Name = "Nike";
            nike.Origin = "USA";
            nike.AddDate = DateTime.Now;            
            context.Brands.Add(nike);

            Brand samsung = new Brand();
            samsung.Name = "Samsung";
            samsung.Origin = "South Korea";
            samsung.AddDate = DateTime.Now;            
            context.Brands.Add(samsung);

            Brand adidas = new Brand();
            adidas.Name = "Adidas";
            adidas.Origin = "Germany";
            adidas.AddDate = DateTime.Now;
            context.Brands.Add(adidas);

            Brand zara = new Brand();
            zara.Name = "Zara";
            zara.Origin = "USA";
            zara.AddDate = DateTime.Now;
            context.Brands.Add(zara);

            Brand puma = new Brand();
            puma.Name = "Puma";
            puma.Origin = "Italy";
            puma.AddDate = DateTime.Now;
            context.Brands.Add(puma);

            Brand apple = new Brand();
            apple.Name = "Apple";
            apple.Origin = "USa";
            apple.AddDate = DateTime.Now;
            context.Brands.Add(apple);

            Product airforce = new Product();
            airforce.Name = "Airforce";
            airforce.UnitPrice = "1900";
            airforce.UnitStock = "10";
            airforce.ProfileImage = "airforce.png";
            airforce.Brand = nike;
            airforce.Category = ayakkabı;
            airforce.AddDate = DateTime.Now;
            context.Products.Add(airforce);

            Product noton = new Product();
            noton.Name = "Noton";
            noton.UnitPrice = "10000";
            noton.UnitStock = "10";
            noton.ProfileImage = "noton.png";
            noton.AddDate = DateTime.Now;
            noton.Category = telefon;
            noton.Brand = samsung;
            context.Products.Add(noton);

            Product stansmit = new Product();
            stansmit.Name = "StanSmit";
            stansmit.UnitPrice = "1499";
            stansmit.UnitStock = "10";
            stansmit.ProfileImage = "stansmit.jpg";
            stansmit.Brand = adidas;
            stansmit.Category = ayakkabı;
            stansmit.AddDate = DateTime.Now;
            context.Products.Add(stansmit);

            Product iphone6 = new Product();
            iphone6.Name = "İphone 6S";
            iphone6.UnitPrice = "4000";
            iphone6.UnitStock = "10";
            iphone6.ProfileImage = "iphone6.jpg";
            iphone6.Brand = apple;
            iphone6.Category = telefon;
            iphone6.AddDate = DateTime.Now;
            context.Products.Add(iphone6);

            Product nikehirka = new Product();
            nikehirka.Name = "Nike Hırka";
            nikehirka.UnitPrice = "899";
            nikehirka.UnitStock = "10";
            nikehirka.ProfileImage = "nikehırka.jpg";
            nikehirka.Brand = nike;
            nikehirka.Category = giyim;
            nikehirka.AddDate = DateTime.Now;
            context.Products.Add(nikehirka);

            Product samsungtv = new Product();
            samsungtv.Name = "Samsung Curved";
            samsungtv.UnitPrice = "23500";
            samsungtv.UnitStock = "10";
            samsungtv.ProfileImage = "samsungtv.jpg";
            samsungtv.AddDate = DateTime.Now;
            samsungtv.Category = televizyon;
            samsungtv.Brand = samsung;
            context.Products.Add(samsungtv);

            Product zaramont = new Product();
            zaramont.Name = "Zara Mont";
            zaramont.UnitPrice = "989";
            zaramont.UnitStock = "10";
            zaramont.ProfileImage = "zaramont.jpg";
            zaramont.AddDate = DateTime.Now;
            zaramont.Category = giyim;
            zaramont.Brand = zara;
            context.Products.Add(zaramont);

            Product iphone14 = new Product();
            iphone14.Name = "İphone 14 Pro Max";
            iphone14.UnitPrice = "41000";
            iphone14.UnitStock = "10";
            iphone14.ProfileImage = "iphone14.jpg";
            iphone14.AddDate = DateTime.Now;
            iphone14.Category = telefon;
            iphone14.Brand = apple;
            context.Products.Add(iphone14);

            Product pumaroma = new Product();
            pumaroma.Name = "Puma Roma";
            pumaroma.UnitPrice = "999";
            pumaroma.UnitStock = "10";
            pumaroma.ProfileImage = "puma.jpg";
            pumaroma.AddDate = DateTime.Now;
            pumaroma.Category = ayakkabı;
            pumaroma.Brand = puma;
            context.Products.Add(pumaroma);

            


            User ahmet = new User();
            ahmet.Name = "Ahmet Asım";
            ahmet.LastName = "Çelik";
            ahmet.UserName = "ahmetasim";
            ahmet.Email = "ahmetasimcelik@gmail.com";
            ahmet.ProfileImage = "aa.png";
            ahmet.Password = "1";
            ahmet.IsAdmin = true;
            context.Users.Add(ahmet);

            context.SaveChanges();
        }

    }

}

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
            context.Categories.Add(bilgisayar);

            Category televizyon = new Category();
            televizyon.Name = "Televizyon";
            televizyon.Description = "Açıklamasatırı";
            televizyon.AddDate = DateTime.Now;
            context.Categories.Add(televizyon);

            

            Brand nike = new Brand();
            nike.Name = "Nike";
            nike.Origin = "USA";
            nike.AddDate = DateTime.Now;
            nike.FoundationYear = 1954;
            nike.ProfileImage = "nike.jpg";
            nike.FoundationYear = 1964;
            nike.Description = "1964 de Amerika da kurulmuştur. Kuruluşundan bugüne dünyanın birçok ülkesine ihracat yapmaktadır.Sektör alanı giyim dir.";
            context.Brands.Add(nike);

            Brand samsung = new Brand();
            samsung.Name = "Samsung";
            samsung.Origin = "South Korea";
            samsung.AddDate = DateTime.Now;
            samsung.FoundationYear = 1938;
            samsung.ProfileImage = "samsung.png";
            samsung.Description = "1938 de Güney Kore da kurulmuştur. Kuruluşundan bugüne dünyanın birçok ülkesine ihracat yapmaktadır.Sektör alanı teknoloji dir.";

            context.Brands.Add(samsung);

            Brand adidas = new Brand();
            adidas.Name = "Adidas";
            adidas.Origin = "Germany";
            adidas.AddDate = DateTime.Now;
            adidas.ProfileImage = "adidas.jpg";
            adidas.FoundationYear = 1949;
            adidas.Description = "1949 de Almanya da kurulmuştur. Kuruluşundan bugüne dünyanın birçok ülkesine ihracat yapmaktadır.Sektör alanı giyim dir.";

            context.Brands.Add(adidas);

            Brand zara = new Brand();
            zara.Name = "Zara";
            zara.Origin = "Spain";
            zara.AddDate = DateTime.Now;
            zara.FoundationYear = 1975;
            zara.ProfileImage = "zara.png";
            zara.Description = "1975 de İspanya da kurulmuştur. Kuruluşundan bugüne dünyanın birçok ülkesine ihracat yapmaktadır.Sektör alanı giyim dir.";

            context.Brands.Add(zara);

            Brand puma = new Brand();
            puma.Name = "Puma";
            puma.Origin = "Germany";
            puma.AddDate = DateTime.Now;
            puma.ProfileImage = "pumalogo.jpg";
            puma.FoundationYear = 1948;
            puma.Description = "1948 de Almanya da kurulmuştur. Kuruluşundan bugüne dünyanın birçok ülkesine ihracat yapmaktadır.Sektör alanı giyim dir.";

            context.Brands.Add(puma);

            Brand apple = new Brand();
            apple.Name = "Apple";
            apple.Origin = "USA";
            apple.AddDate = DateTime.Now;
            apple.ProfileImage = "apple.jpg";
            apple.FoundationYear = 1976;
            apple.Description = "1976 da Amerika da kurulmuştur. Kuruluşundan bugüne dünyanın birçok ülkesine ihracat yapmaktadır.Sektör alanı teknoloji dir.";

            context.Brands.Add(apple);

            Brand huawei = new Brand();
            huawei.Name = "Huawei";
            huawei.Origin = "Chinese";
            huawei.AddDate = DateTime.Now;
            huawei.ProfileImage = "huawei.png";
            huawei.FoundationYear = 1987;
            huawei.Description = "1987 de Çin de kurulmuştur. Kuruluşundan bugüne dünyanın birçok ülkesine ihracat yapmaktadır.Sektör alanı teknoloji dir.";

            context.Brands.Add(huawei);

            Brand asus = new Brand();
            asus.Name = "Asus";
            asus.Origin = "Taipei";
            asus.AddDate = DateTime.Now;
            asus.ProfileImage = "asus.png";
            asus.FoundationYear = 1989;
            asus.Description = "1989 de Tayvan da kurulmuştur. Kuruluşundan bugüne dünyanın birçok ülkesine ihracat yapmaktadır.Sektör alanı teknoloji dir.";

            context.Brands.Add(asus);

            Brand mavi = new Brand();
            mavi.Name = "Mavi";
            mavi.Origin = "Turkey";
            mavi.AddDate = DateTime.Now;
            mavi.ProfileImage = "mavi.png";
            mavi.FoundationYear = 1991;
            mavi.Description = "1991 de Türkiye de kurulmuştur. Kuruluşundan bugüne dünyanın birçok ülkesine ihracat yapmaktadır.Sektör alanı giyim dir.";

            context.Brands.Add(mavi);

            Product airforce = new Product();
            airforce.Name = "Airforce";
            airforce.UnitPrice = 1900;
            airforce.UnitStock = 10;
            airforce.ProfileImage = "airforce.png";
            airforce.Brand = nike;
            airforce.Category = ayakkabı;
            airforce.AddDate = DateTime.Now;
            
            context.Products.Add(airforce);

            Product noton = new Product();
            noton.Name = "Noton";
            noton.UnitPrice = 10000;
            noton.UnitStock = 10;
            noton.ProfileImage = "noton.png";
            noton.AddDate = DateTime.Now;
            noton.Category = telefon;
            noton.Brand = samsung;
            context.Products.Add(noton);

            Product stansmit = new Product();
            stansmit.Name = "StanSmit";
            stansmit.UnitPrice = 1499;
            stansmit.UnitStock = 10;
            stansmit.ProfileImage = "stansmit.jpg";
            stansmit.Brand = adidas;
            stansmit.Category = ayakkabı;
            stansmit.AddDate = DateTime.Now;
            context.Products.Add(stansmit);

            Product iphone6 = new Product();
            iphone6.Name = "İphone 6S";
            iphone6.UnitPrice = 4000;
            iphone6.UnitStock = 10;
            iphone6.ProfileImage = "iphone6.jpg";
            iphone6.Brand = apple;
            iphone6.Category = telefon;
            iphone6.AddDate = DateTime.Now;
            context.Products.Add(iphone6);

            Product nikehirka = new Product();
            nikehirka.Name = "Nike Hırka";
            nikehirka.UnitPrice = 899;
            nikehirka.UnitStock = 10;
            nikehirka.ProfileImage = "nikehırka.jpg";
            nikehirka.Brand = nike;
            nikehirka.Category = giyim;
            nikehirka.AddDate = DateTime.Now;
            context.Products.Add(nikehirka);

            Product samsungtv = new Product();
            samsungtv.Name = "Samsung Curved";
            samsungtv.UnitPrice = 23500;
            samsungtv.UnitStock = 10;
            samsungtv.ProfileImage = "samsungtv.jpg";
            samsungtv.AddDate = DateTime.Now;
            samsungtv.Category = televizyon;
            samsungtv.Brand = samsung;
            context.Products.Add(samsungtv);

            Product zaramont = new Product();
            zaramont.Name = "Zara Mont";
            zaramont.UnitPrice = 989;
            zaramont.UnitStock = 10;
            zaramont.ProfileImage = "zaramont.jpg";
            zaramont.AddDate = DateTime.Now;
            zaramont.Category = giyim;
            zaramont.Brand = zara;
            context.Products.Add(zaramont);

            Product adidasayakkabı = new Product();
            adidasayakkabı.Name = "Adidas B74494";
            adidasayakkabı.UnitPrice = 998;
            adidasayakkabı.UnitStock = 10;
            adidasayakkabı.ProfileImage = "adidasayakkabı.jpg";
            adidasayakkabı.AddDate = DateTime.Now;
            adidasayakkabı.Category = ayakkabı;
            adidasayakkabı.Brand = adidas;
            context.Products.Add(adidasayakkabı);

            Product iphone14 = new Product();
            iphone14.Name = "İphone 14 Pro Max";
            iphone14.UnitPrice = 41000;
            iphone14.UnitStock = 10;
            iphone14.ProfileImage = "iphone14.jpg";
            iphone14.AddDate = DateTime.Now;
            iphone14.Category = telefon;
            iphone14.Brand = apple;
            context.Products.Add(iphone14);

            Product pumaroma = new Product();
            pumaroma.Name = "Puma Roma";
            pumaroma.UnitPrice = 999;
            pumaroma.UnitStock = 10;
            pumaroma.ProfileImage = "puma.jpg";
            pumaroma.AddDate = DateTime.Now;
            pumaroma.Category = ayakkabı;
            pumaroma.Brand = puma;
            context.Products.Add(pumaroma);

            Product huaweilaptop = new Product();
            huaweilaptop.Name = "Huawei Laptop";
            huaweilaptop.UnitPrice = 12999;
            huaweilaptop.UnitStock = 10;
            huaweilaptop.ProfileImage = "huaweilaptop.jpg";
            huaweilaptop.AddDate = DateTime.Now;
            huaweilaptop.Category = bilgisayar;
            huaweilaptop.Brand = huawei;
            context.Products.Add(huaweilaptop);

            Product mavisweat = new Product();
            mavisweat.Name = "Turuncu Sweat";
            mavisweat.UnitPrice = 299;
            mavisweat.UnitStock = 10;
            mavisweat.ProfileImage = "mavisweat2.jpg";
            mavisweat.AddDate = DateTime.Now;
            mavisweat.Category = giyim;
            mavisweat.Brand = mavi;
            context.Products.Add(mavisweat);

            Product huaweitelefon = new Product();
            huaweitelefon.Name = "P20 Lite 64GB";
            huaweitelefon.UnitPrice = 8250;
            huaweitelefon.UnitStock = 10;
            huaweitelefon.ProfileImage = "huaweitelefon.jpg";
            huaweitelefon.AddDate = DateTime.Now;
            huaweitelefon.Category = telefon;
            huaweitelefon.Brand = huawei;
            context.Products.Add(huaweitelefon);

            Product adidasesofman = new Product();
            adidasesofman.Name = "Adidas Eşofman";
            adidasesofman.UnitPrice = 349;
            adidasesofman.UnitStock = 10;
            adidasesofman.ProfileImage = "adidasesofman.jpg";
            adidasesofman.AddDate = DateTime.Now;
            adidasesofman.Category = giyim;
            adidasesofman.Brand = adidas;
            context.Products.Add(adidasesofman);

            Product macbook = new Product();
            macbook.Name = "MacBook Air";
            macbook.UnitPrice = 24999;
            macbook.UnitStock = 10;
            macbook.ProfileImage = "macbookair.jpg";
            macbook.AddDate = DateTime.Now;
            macbook.Category = bilgisayar;
            macbook.Brand = apple;
            context.Products.Add(macbook);

            Product zaraderi = new Product();
            zaraderi.Name = "Zara Deri Ceket";
            zaraderi.UnitPrice = 459;
            zaraderi.UnitStock = 10;
            zaraderi.ProfileImage = "zaraderi.jpg";
            zaraderi.AddDate = DateTime.Now;
            zaraderi.Category = giyim;
            zaraderi.Brand = zara;
            context.Products.Add(zaraderi);

            Product asusmonitor = new Product();
            asusmonitor.Name = "Asus Monitör 244Hz";
            asusmonitor.UnitPrice = 9999;
            asusmonitor.UnitStock = 10;
            asusmonitor.ProfileImage = "asusmonitör.jpg";
            asusmonitor.AddDate = DateTime.Now;
            asusmonitor.Category = bilgisayar;
            asusmonitor.Brand = asus;
            context.Products.Add(asusmonitor);

            Product asuslaptop = new Product();
            asuslaptop.Name = "Asus Laptop 8GB 256SSD";
            asuslaptop.UnitPrice = 32500;
            asuslaptop.UnitStock = 10;
            asuslaptop.ProfileImage = "asuslaptop.jpg";
            asuslaptop.AddDate = DateTime.Now;
            asuslaptop.Category = bilgisayar;
            asuslaptop.Brand = asus;
            context.Products.Add(asuslaptop);
                    

            Product mavisweat2 = new Product();
            mavisweat2.Name = "Mavi Sweat";
            mavisweat2.UnitPrice = 299;
            mavisweat2.UnitStock = 10;
            mavisweat2.ProfileImage = "mavisweat.jpg";
            mavisweat2.AddDate = DateTime.Now;
            mavisweat2.Category = giyim;
            mavisweat2.Brand = mavi;
            context.Products.Add(mavisweat2);


            User ahmet = new User();
            ahmet.Name = "Ahmet Asım";
            ahmet.LastName = "Çelik";
            ahmet.UserName = "ahmetasim";
            ahmet.Email = "ahmetasimcelik@gmail.com";
            ahmet.ProfileImage = "aa.png";
            ahmet.Password = "1";
            ahmet.IsAdmin = true;
            context.Users.Add(ahmet);

            User hilal = new User();
            hilal.Name = "Hilal Nur";
            hilal.LastName = "Çelik";
            hilal.UserName = "hilal";
            hilal.Email = "hilalnur@icloud.com";
            hilal.ProfileImage = "hilal.jpg";
            hilal.Password = "1";
            hilal.IsAdmin = false;
            context.Users.Add(hilal);

            context.SaveChanges();
        }

    }

}

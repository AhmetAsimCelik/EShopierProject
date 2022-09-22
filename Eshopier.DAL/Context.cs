using EShopier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshopier.DAL
{
    public class Context:DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-N031PB4; Database=EShopierProject; uid=sa; pwd=1";
            //Database.SetInitializer(new İnitializer());
            User user = new User()
            {
                Name="Ahmet Asım",
                LastName="Çelik",
                UserName="ahmetasimcelik",
                Email="@ahmetasimcelikgmail.com",
                Password="1",
                IsAdmin=true,
                
            };
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Product> Products { get; set; }


    }
}

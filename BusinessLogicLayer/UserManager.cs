using Eshopier.DAL;
using EShopier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UserManager
    {
       public Repository<User> user = new Repository<User>();

       //public List<User> RegisterUser(User u)
       // {
            
       //     //return user.Instert(u);
       // }
       
    }
}

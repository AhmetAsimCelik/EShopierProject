using Eshopier.DAL;
using EShopier.Entities;
using EShopier.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CartManager
    {
        Repository<CartModel> cart = new Repository<CartModel>();
       
        
       
       
        //public CartModel GetCart(int id)
        //{
        //    return cart.Find(c => c. == id);
        //}

    }
}

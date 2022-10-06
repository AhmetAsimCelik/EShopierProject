using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EShopier.Entities.ViewModels
{
    public class CartModel
    {
        private List<CartLine> _cartLines = new List<CartLine>();
        public List<CartLine> CartLines
        {
            get { return _cartLines; }
        }
        public void AddProduct(Product product, int quantity)
        {
            var line = _cartLines.Where(x => x.Product.ID == product.ID).FirstOrDefault();
            if (line==null)
            {
                _cartLines.Add(new CartLine() { Product=product,Quantity=quantity});
            }
            else
            {
                line.Quantity += quantity;
            }
                 
        }
        public void DeleteProduct(Product product)
        {
            _cartLines.RemoveAll(x => x.Product.ID == product.ID);

        }
        public double Total()
        {
            double total = _cartLines.Sum(x => x.Product.UnitPrice * x.Quantity);
            double quantity = _cartLines.Sum(x => x.Quantity);
            if (total > 24999)
            {
                total = total * 0.90;
            }           
            else if (total < 499)
            {
                total =total+ 12;
            }
           
            return total;
            
        }
        public double TotalQuantity()
        {
           
            return _cartLines.Sum(x => x.Quantity);
        }
        public double Ship()
        {
            //double total = _cartLines.Sum(x => x.Quantity);
            double total = _cartLines.Sum(x => x.Product.UnitPrice * x.Quantity);



            if (total > 499)
            {
                total= 0;
            }
            else
            {
                total = 12;
                
            }
           
            return total;
        }
        public double Sale()
        {
            
            double fiyat = _cartLines.Sum(x => x.Product.UnitPrice * x.Quantity);

            if (fiyat > 25000)
            {
                fiyat = 10;
            }
            else
            {
                fiyat = 0;
             
            }

            return fiyat;
        }
        public void Clear()
        {
            _cartLines.Clear();
        }
    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}

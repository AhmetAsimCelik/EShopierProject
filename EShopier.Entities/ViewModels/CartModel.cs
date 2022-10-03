using System;
using System.Collections.Generic;
using System.Linq;
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
            return _cartLines.Sum(x => x.Product.UnitPrice * x.Quantity);
        }
        public double TotalQuantity()
        {
            return _cartLines.Sum(x => x.Quantity);
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

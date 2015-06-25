using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> list;

        public void AddProduct(IProduct product)
        {
            this.list.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.list.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (this.list.Contains(product))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal TotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}

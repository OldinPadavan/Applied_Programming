using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Three
{
    internal class Storage
    {
        private List<Product> _products;


        Storage()
        {
            _products = new List<Product>();
        }

        public int GetCapacity()
        {
            return _products.Count;
        }
        public int GetProductCount(Product product)
        {
            int count = 0;
            foreach (Product p in _products)
            {
                if (p.GetProductCode() == product.GetProductCode())
                {
                    count++;
                }
            }
            return count;
        }

    }
}

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


        public Storage()
        {
            _products = new List<Product>();
        }

        public int GetCapacity()
        {
            return _products.Count;
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public Product GetProduct(int index)
        {
            if (index > 0 & index < _products.Count())
            {
                return _products[index];
            }
            return null;
        }

    }
}

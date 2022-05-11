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
        public  int GetProductCount(Product product)
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
        public  double GetProductBuyingPrice(Product product)
        {
            double summ = 0;
            foreach (Product p in _products)
            {
                if (p.GetProductCode() == product.GetProductCode())
                {
                    summ += p.GetBuyingPrice();
                }
            }
            return summ;

        }

        public  double GetProductSellingPrice(Product product)
        {
            double summ = 0;
            foreach (Product p in _products)
            {
                if (p.GetProductCode() == product.GetProductCode())
                {
                    summ += p.GetSellingPrice();
                }
            }
            return summ;

        }

        public double GetProfit(Product product)
        {
            return this.GetProductSellingPrice(product) - this.GetProductBuyingPrice(product); 
        }

    }
}

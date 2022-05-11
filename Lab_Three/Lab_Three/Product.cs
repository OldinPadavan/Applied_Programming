using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Three
{
    internal class Product
    {
        public enum ProductType
        {
            Food,
            Hardware,
            Medical_supplie,
            Tool,
            Unknown

        }
        private String _productName;
        private ProductType _productType;
        private long _productCode;
        private double _buyingPrice;
        private double _sellinglPrice;

         public Product(String Name, String Type, int ProductCode)
        {
            this._productName = Name;
            this._productType = (ProductType) Enum.Parse(typeof(ProductType), Type);
            this._productCode = ProductCode;
            this._buyingPrice = 0;
            this._sellinglPrice = 0;
          
        }

        public Product(String Name, String Type, int ProductCode, double BuyingPrice, double SellingPrice)
        {
            this._productName = Name;
            this._productType = (ProductType)Enum.Parse(typeof(ProductType), Type);
            this._productCode = ProductCode;
            this._buyingPrice = BuyingPrice;
            this._sellinglPrice = SellingPrice;
        }

        public void SetProductType(String Type)
        {
           this._productType = (ProductType)Enum.Parse(typeof(ProductType), Type);
        }
        public void SetName(String Name)
        {
            this._productName = Name;
        }
        public void SetProductCode(long ProductCode)
        {
            this._productCode = ProductCode;
        }
        public void SetBuyingPrice(double BuyingPrice)
        {
            this._buyingPrice = BuyingPrice;
        }
        public void SetSellingPrice(double SellingPrice)
        {
            this._sellinglPrice = SellingPrice;
        }

        public String GetProductName()
        {
            return this._productName;
        }
        public ProductType GetProductType()
        {
            return this._productType;
        }
        public long GetProductCode()
        {
            return this._productCode;
        }
        public double GetBuyingPrice()
        {
            return this._buyingPrice;
        }
        public double GetSellingPrice()
        {
            return this._sellinglPrice;
        }




        public override string? ToString()
        {
            return this._productName + "\n" + this._productType + "\n" + this._productCode;
        }
    }
  
}

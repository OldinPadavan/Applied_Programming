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
            Medical_s,
            Tool,
            Unknown

        }
        private String _productName;
        private ProductType _productType;
        private int _amount;
        private double _buyingPrice;
        private double _sellinglPrice;

    
        public Product(String Name, String Type,int Amount, double BuyingPrice, double SellingPrice)
        {
            this._productName = Name;
            this._productType = (ProductType)Enum.Parse(typeof(ProductType), Type);
            this._buyingPrice = BuyingPrice;
            this._sellinglPrice = SellingPrice;
            _amount += Amount;
        }

        public void SetProductType(String Type)
        {
           this._productType = (ProductType)Enum.Parse(typeof(ProductType), Type);
        }
        public void SetName(String Name)
        {
            this._productName = Name;
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
        public double GetBuyingPrice()
        {
            return this._buyingPrice;
        }
        public double GetSellingPrice()
        {
            return this._sellinglPrice;
        }
        public int GetAmount()
        {
            return _amount;
        }
        public double GetProfit()
        {
            return (this._sellinglPrice - this._buyingPrice) * this._amount;
        }




        public override string? ToString()
        {
            return this._productName +"\t" + " | "+ "\t" + this._productType + "\t" + " | " + "\t" + this.GetBuyingPrice() +
            " | " + "\t" + this.GetSellingPrice() + " | " + "\t" + this.GetProfit();
        }
    }
  
}

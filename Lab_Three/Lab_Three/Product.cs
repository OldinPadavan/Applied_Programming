using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Three
{
    internal class Product
    {
        enum ProductType
        {
            Food,
            Hardware,
            Medical_supplie,
            Tool,
            Unknown

        }
        private String Name;
        private ProductType Type;
        private long ProductCode;

        public Product()
        {
            Name = "Unkown product";
            Type = ProductType.Unknown;
            ProductCode = 0;
            Console.WriteLine("Added product without information!/nYou should add an information about this unit.");

        }
         public Product(String Name, String Type, int ProductCode)
        {
            this.Name = Name;
            this.Type = (ProductType) Enum.Parse(typeof(ProductType), Type); ;
            this.ProductCode = ProductCode;
            Console.WriteLine("Adding product was successful!");


        }

        public void SetProductType(String Type)
        {
           switch (Type)
            {
               
            }
        }

    }
  
}

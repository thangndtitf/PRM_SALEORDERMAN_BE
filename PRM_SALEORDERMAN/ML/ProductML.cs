using System;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.ML
{
	public class ProductML
	{
		public int productID { get; set; }
		public int productTypeID { get; set; }
		public int currentInstock { get; set; }
		public String productName { get; set; }
		public String description { get; set; }
		public decimal price { get; set; }

        public ProductML(int productID, int productTypeID, int currentInstock, string productName, string description, decimal price)
        {
            this.productID = productID;
            this.productTypeID = productTypeID;
            this.currentInstock = currentInstock;
            this.productName = productName;
            this.description = description;
            this.price = price;
        }

        public ProductML(int productTypeID, int currentInstock, string productName, string description, decimal price)
        {
            this.productTypeID = productTypeID;
            this.currentInstock = currentInstock;
            this.productName = productName;
            this.description = description;
            this.price = price;
        }

        public ProductML()
        {
        }
    }
}




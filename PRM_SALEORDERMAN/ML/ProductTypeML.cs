using System;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.ML
{
	public class ProductTypeML
    {
        public int productTypeId { get; set; }
        public String productTypeName { get; set; }
        public String description { get; set; }
        public String imageUrl { get; set; }

        public ProductTypeML(int productTypeId, string productTypeName, string description, string imageUrl)
        {
            this.productTypeId = productTypeId;
            this.productTypeName = productTypeName;
            this.description = description;
            this.imageUrl = imageUrl;
        }

        public ProductTypeML()
        {
        }
    }
}


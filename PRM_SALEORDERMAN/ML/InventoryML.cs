using System;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.ML
{
	public class InventoryML
    {
		public int productID { get; set; }
		public int storeID { get; set; }
		public int instockQuantity { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is InventoryML mL &&
                   productID == mL.productID &&
                   storeID == mL.storeID &&
                   instockQuantity == mL.instockQuantity;
        }


    }
}



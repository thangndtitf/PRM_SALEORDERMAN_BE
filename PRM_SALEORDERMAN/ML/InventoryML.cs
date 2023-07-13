namespace PRM_SALEORDERMAN.ML
{
	public class InventoryML
    {
		public int productID { get; set; }
        public String productName { get; set; }
        public int storeID { get; set; }
        public String storeName { get; set; }
        public int instockQuantity { get; set; }

        public InventoryML(int productID, int storeID, string storeName, int instockQuantity)
        {
            this.productID = productID;
            this.storeID = storeID;
            this.storeName = storeName;
            this.instockQuantity = instockQuantity;
        }

        public InventoryML()
        {
        }
    }
}



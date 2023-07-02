using System;
namespace PRM_SALEORDERMAN.ML
{
	public class SaleOrderML
	{
        public int saleOrderID { get; set; }
        public int custId { get; set; }
        public int currentStatus { get; set; }
        public DateTime createdDate { get; set; }
        public String createdStaffName { get; set; }
        public int saleStoreID { get; set; }

        public SaleOrderML(int saleOrderID, int custId, int currentStatus, DateTime createdDate, string createdStaffName, int saleStoreID)
        {
            this.saleOrderID = saleOrderID;
            this.custId = custId;
            this.currentStatus = currentStatus;
            this.createdDate = createdDate;
            this.createdStaffName = createdStaffName;
            this.saleStoreID = saleStoreID;
        }

        public SaleOrderML(int custId, int currentStatus, string createdStaffName, int saleStoreID)
        {
            this.custId = custId;
            this.currentStatus = currentStatus;
            this.createdStaffName = createdStaffName;
            this.saleStoreID = saleStoreID;
        }

        public SaleOrderML()
        {
        }
    }

}


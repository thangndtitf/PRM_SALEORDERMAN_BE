using System;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.ML
{
	public class StoreML
    {
        public int storeID { get; set; }
        public String productName { get; set; }
        public String companyName { get; set; }
        public String storeCountry { get; set; }
        public String storeProvince { get; set; }
        public String storeDistrict { get; set; }
        public String storeWard { get; set; }
        public String storeAddress { get; set; }
        public String storeFullAddress { get; set; }
        public String description { get; set; }

        public StoreML(int storeID, string productName,
            string companyName, string storeCountry,
            string storeProvince, string storeDistrict,
            string storeWard, string storeAddress,
            string storeFullAddress, string description)
        {
            this.storeID = storeID;
            this.productName = productName;
            this.companyName = companyName;
            this.storeCountry = storeCountry;
            this.storeProvince = storeProvince;
            this.storeDistrict = storeDistrict;
            this.storeWard = storeWard;
            this.storeAddress = storeAddress;
            this.storeFullAddress = storeFullAddress;
            this.description = description;
        }

        public StoreML(string productName, string companyName,
            string storeCountry, string storeProvince,
            string storeDistrict, string storeWard,
            string storeAddress, string storeFullAddress,
            string description)
        {
            this.productName = productName;
            this.companyName = companyName;
            this.storeCountry = storeCountry;
            this.storeProvince = storeProvince;
            this.storeDistrict = storeDistrict;
            this.storeWard = storeWard;
            this.storeAddress = storeAddress;
            this.storeFullAddress = storeFullAddress;
            this.description = description;
        }
    }
}



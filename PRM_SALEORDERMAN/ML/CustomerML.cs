using System;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.ML
{
	public class CustomerML
    {

        public int customerID { get; set; }
        public String userName { get; set; }
        public String password { get; set; }
        public String customerFullName { get; set; }
        public String cusCountry { get; set; }
        public String cusProvince { get; set; }
        public String cusDistrict { get; set; }
        public String cusWard { get; set; }
        public String cusAddress { get; set; }
        public String cusFullAddress { get; set; }
        public String cusPhone { get; set; }
        public String cusEmail { get; set; }

        public CustomerML(int customerID, string userName,
            string password, string customerFullName,
            string country, string cusProvince,
            string cusDestrict, string cusWard,
            string cusAddress, string cusFullAddress,
            string cusPhone, string cusEmail)
        {
            this.customerID = customerID;
            this.userName = userName;
            this.password = password;
            this.customerFullName = customerFullName;
            this.cusCountry = country;
            this.cusProvince = cusProvince;
            this.cusDistrict = cusDestrict;
            this.cusWard = cusWard;
            this.cusAddress = cusAddress;
            this.cusFullAddress = cusFullAddress;
            this.cusPhone = cusPhone;
            this.cusEmail = cusEmail;
        }

        public CustomerML(string userName, string password,
            string customerFullName, string country,
            string cusProvince, string cusDestrict,
            string cusWard, string cusAddress,
            string cusFullAddress, string cusPhone,
            string cusEmail)
        {
            this.userName = userName;
            this.password = password;
            this.customerFullName = customerFullName;
            this.cusCountry = country;
            this.cusProvince = cusProvince;
            this.cusDistrict = cusDestrict;
            this.cusWard = cusWard;
            this.cusAddress = cusAddress;
            this.cusFullAddress = cusFullAddress;
            this.cusPhone = cusPhone;
            this.cusEmail = cusEmail;
        }

        public CustomerML()
        {
        }
    }
}


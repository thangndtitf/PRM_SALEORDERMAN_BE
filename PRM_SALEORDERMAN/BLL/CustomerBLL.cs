using System;
using PRM_SALEORDERMAN.DAL;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.BLL
{
	public class CustomerBLL
	{
        private IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

        public CustomerML getCustomerInfo(int customerID)
        {
            _ = new CustomerML();
            if (customerID <= 0)
            {
                throw new Exception("Error customerID <= 0 ");
            }
            else
            {
                CustomerDAL customerDAL = new CustomerDAL(configuration);
                CustomerML customer;
                if (customerDAL.getInforCus(customerID) == null)
                {
                    return null;
                }
                else
                {
                    customer = customerDAL.getInforCus(customerID);
                }
                return customer;

            }
        }

        public CustomerML loginUP(String userName, string password)
        {
            CustomerML customer = new CustomerML();
            if (userName == null || password == null)
            {
                throw new Exception("USername or password is null");
            }
            else
            {
                CustomerDAL customerDAL = new CustomerDAL(configuration);
               
                if( customerDAL.loginUP(userName, password) == null)
                {
                    return null;
                }
                else
                {
                    customer = customerDAL.loginUP(userName, password);
                }
                return customer;
            }
            
        }

        public CustomerML addNewADDress(int cusID, String cusAddress, String cussPhone, String cusPostalCode) {
            CustomerML resultObj = new CustomerML();
            CustomerDAL customerDAL = new CustomerDAL(configuration);
            resultObj = customerDAL.addNewAddress(cusID, cusAddress, cussPhone, cusPostalCode);


            return resultObj;
        }


    }
}


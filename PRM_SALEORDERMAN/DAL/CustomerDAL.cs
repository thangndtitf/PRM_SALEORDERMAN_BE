using System;
using System.Data;
using System.Text.Json;
using Dapper;
using Microsoft.Data.SqlClient;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.DAL
{
	public class CustomerDAL
	{
        private readonly IConfiguration _config;

        public CustomerDAL(IConfiguration config)
        {
            _config = config;
        }

        public CustomerML getInforCus(int customerID)
        {
            CustomerML customer = new CustomerML();
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                connection.Open();
                String queryStr = "exec CUSTOMER_GETINFO @CUSTOMERID";
                var parameter = new DynamicParameters();
                parameter.Add("@CUSTOMERID", customerID);
                customer = connection.QueryFirstOrDefault<CustomerML>(queryStr, parameter);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return customer;
        }

        public CustomerML loginUP(String userName, String password)
        {
            CustomerML customer = new CustomerML();
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
               
                connection.Open();
                String queryStr = "exec CUSTOMER_LOGIN_UP @CUSEMAIL, @PASSWORD";
                var parameter = new DynamicParameters();
                parameter.Add("@CUSEMAIL", userName);
                parameter.Add("@PASSWORD", password);
                customer = connection.QueryFirstOrDefault<CustomerML>(queryStr, parameter );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return customer;
        }


        public CustomerML addNewAddress(int cusID,String cusAddress, String cussPhone, String cusPostalCode) {
            CustomerML resultObj = new CustomerML();
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));


            try
            {
                connection.Open();

                String storeProcedure = "CUSTOMER_ADDADDRESS";
                var parameter = new DynamicParameters();
                parameter.Add("@CUSFULLADDRESS", cusAddress);
                parameter.Add("@CUSPHONE", cussPhone);
                parameter.Add("@POSTALCODE", cusPostalCode);
                parameter.Add("@CUSTOMERID", cusID);
                resultObj = (CustomerML)connection.QueryFirstOrDefault<CustomerML>(storeProcedure, parameter, commandType: CommandType.StoredProcedure);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                connection.Close();
            }



            return resultObj;
        }
        

    }
}


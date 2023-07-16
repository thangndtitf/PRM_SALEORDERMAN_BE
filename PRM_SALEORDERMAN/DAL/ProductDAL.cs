using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.DAL
{
	public class ProductDAL
	{
		private IConfiguration _config;

        public ProductDAL(IConfiguration config)
        {
            _config = config;
        }

        public List<ProductML> getAllProduct()
        {
            List<ProductML> listResult = new List<ProductML>();
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                connection.Open();
                String queryStr = " PRODUCT_GETALL ";
               
                listResult = (List<ProductML>)connection.Query<ProductML>(queryStr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                connection.Close();
            }

            return listResult;
        }

        public ProductML getProductByID(int productID) {
            ProductML resultObj = new ProductML();
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                connection.Open();
                String storeProcedure = "PRODUCT_GETDETAILBYID";
                var parameter = new DynamicParameters();
                parameter.Add("@PRODUCTID", productID);
                resultObj = connection.QueryFirstOrDefault<ProductML>(storeProcedure, parameter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally {
                connection.Close();
            }

            return resultObj;
        }

        public List<ProductML> getProductByType(int productTypeID)
        {
            List<ProductML> listResult = new List<ProductML>();
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                connection.Open();
                String storeProcedure = "PRODUCT_GETALLBYTYPE";
                var parameter = new DynamicParameters();
                parameter.Add("@PRODUCTTYPEID", productTypeID);
                listResult = (List<ProductML>)connection.Query<ProductML>(storeProcedure, parameter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return listResult;
        }

    }
}


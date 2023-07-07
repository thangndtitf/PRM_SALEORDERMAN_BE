using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.DAL
{
	public class InventoryDAL
	{
        private readonly IConfiguration _config;

        public InventoryDAL(IConfiguration config)
        {
            _config = config;
        }

        public List<InventoryML> getAllInvt() {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            List<InventoryML> listResult = new List<InventoryML>();

            try
            {
                connection.Open();
                String storeProcedure = "INVENTORY_GETALLINSTOC";
                listResult = (List<InventoryML>)connection.Query<InventoryML>(storeProcedure, commandType: CommandType.StoredProcedure);
                
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



        public InventoryML getInventoryByProduct(int productID) {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));

            InventoryML result = new InventoryML();

            try
            {
                connection.Open();
                String queryStr = " INVENTORY_GETCURSTOCK";
                var parameter = new DynamicParameters();
                parameter.Add("@PRODUCTID", productID);
                result = connection.QueryFirst<InventoryML>(queryStr, parameter, commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                connection.Close();

            }

            return result;

        }
    }
}


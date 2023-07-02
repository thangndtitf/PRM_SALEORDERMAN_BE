using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.DAL
{
	public class SaleOrderDAL
	{
        private readonly IConfiguration _config;
       
        public SaleOrderDAL(IConfiguration config)
        {
            _config = config;
        }

        public SaleOrderML getSaleOrderByID(int saleOrderID)
        {
            SaleOrderML saleOrder = new SaleOrderML();
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                connection.Open();
                String queryStr = "exec SALEORDER_GETBYID @SALEORDERID";
                var value = new { SALEORDERID = saleOrderID };
                saleOrder = connection.QueryFirstOrDefault<SaleOrderML>(queryStr, value);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString);
            }
            finally
            {
                connection.Close();
            }
            return saleOrder;

        }


        public List<SaleOrderML> getAllSaleOrder()
        {
            List<SaleOrderML> listResult = new List<SaleOrderML>();
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                connection.Open();
                String queryStr = "exec SALEORDER_GETALL";
                listResult = (List<SaleOrderML>)connection.Query<SaleOrderML>(queryStr);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally{
                connection.Close();
            }
            return listResult;
        }

        public int insertNewSaleOrder(SaleOrderML saleOrderML) {
            int insertID = 0;
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {

                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@CUSTOMERID", saleOrderML.custId);
                parameters.Add("@CURRENTSTATUS", saleOrderML.currentStatus);
                parameters.Add("@CREATEDSTAFFNAME", saleOrderML.createdStaffName);
                parameters.Add("@SALESTOREID", saleOrderML.saleStoreID);
                parameters.Add("@SALEORDERID", dbType: DbType.Int32, direction: ParameterDirection.Output);
                var query = "dbo.CREATESALEORDER";
                var result = connection.QueryFirstOrDefault<int>(query, parameters, commandType: CommandType.StoredProcedure);
                var saleOrderId = parameters.Get<int>("@SALEORDERID");
                insertID = saleOrderId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return insertID;
        }


    }
}


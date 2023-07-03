using System;
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
                String queryStr = "EXEC PRODUCT_GETALL ";
               
                listResult = (List<ProductML>)connection.Query<ProductML>(queryStr, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

            }

            return listResult;
        }

    }
}


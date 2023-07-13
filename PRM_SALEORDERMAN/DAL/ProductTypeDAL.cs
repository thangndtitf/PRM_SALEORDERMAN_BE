using Dapper;
using Microsoft.Data.SqlClient;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.DAL
{
	public class ProductTypeDAL
	{
        private readonly IConfiguration _config;

        public ProductTypeDAL(IConfiguration config)
        {
            _config = config;
        }

        public List<ProductTypeML> getListProductType() {
            List<ProductTypeML> listResult = new List<ProductTypeML>();
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                connection.Open();
                String storeProcedure = "PRODUCTTYPE_GETALL";
                listResult =(List<ProductTypeML>) connection.Query<ProductTypeML>(storeProcedure);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return listResult;
        }

    }
}


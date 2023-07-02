
using Dapper;
using Microsoft.Data.SqlClient;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.DAL
{
	public class SaleOrderDetailDAL
	{
        private readonly IConfiguration _config;

        public SaleOrderDetailDAL(IConfiguration config)
        {
            _config = config;
        }

        public SaleOrderDetailML insertNewSaleOrderDetail(SaleOrderDetailML saleOrderDetailML)
        {
            SaleOrderDetailML insertObj = new SaleOrderDetailML();
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                connection.Open();
                String querStr = "EXEC SALEORDERDETAIL_CREATE @SALEORDERID,@PRODUCTID,@QUANTITY,@TOTALPRICE,@PRODUCTPRICE,@DISCOUNTPRICE";
                var value = new { @SALEORDERID = saleOrderDetailML.saleOrderID,
                    @PRODUCTID = saleOrderDetailML.productID,
                    @QUANTITY = saleOrderDetailML.quantity,
                    @TOTALPRICE = saleOrderDetailML.totalPrice,
                    @PRODUCTPRICE = saleOrderDetailML.productPrice,
                    @DISCOUNTPRICE = saleOrderDetailML.discountPrice };
                insertObj = (SaleOrderDetailML)connection.QueryFirstOrDefault<SaleOrderDetailML>(querStr, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return insertObj;
        }



    }
}


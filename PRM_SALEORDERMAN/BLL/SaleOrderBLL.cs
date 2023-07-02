using System;
using PRM_SALEORDERMAN.DAL;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.BLL
{
	public class SaleOrderBLL
	{
		private IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

		public SaleOrderML getSaleOrderByID(int saleOrderID) // Ham lay ra don hang theo ma don hang
		{
			//SaleOrderML saleOrderML = new SaleOrderML();
			SaleOrderDAL saleOrderDAL = new SaleOrderDAL(configuration);
			if(saleOrderID <= 0)
			{
				return null;
			}
			else
			{
				return saleOrderDAL.getSaleOrderByID(saleOrderID);
			}
		}

		public List<SaleOrderML> getAllSaleOrder() // Ham lay ra All don hang
		{
            SaleOrderDAL saleOrderDAL = new SaleOrderDAL(configuration);
			List<SaleOrderML> listResult = saleOrderDAL.getAllSaleOrder();
			if(listResult.Count <= 0)
			{
				listResult = null;
			}
			return listResult;
        }

		public int insertNewSaleOrder(SaleOrderML saleOrder, List<SaleOrderDetailML> listSODetail)
		{
			
			int saleOrderID = 0;
			SaleOrderDetailBLL saleOrderDetailBLL = new SaleOrderDetailBLL();
            SaleOrderDAL saleOrderDAL = new SaleOrderDAL(configuration);
            saleOrderID = saleOrderDAL.insertNewSaleOrder(saleOrder);
			saleOrderDetailBLL.insertNewSaleOrderDetails(listSODetail, saleOrderID);
			
			if(saleOrderID <= 0)
			{
				throw new Exception("Error at SaleOrderBLL");
			}
            return saleOrderID;
		}


    }
}


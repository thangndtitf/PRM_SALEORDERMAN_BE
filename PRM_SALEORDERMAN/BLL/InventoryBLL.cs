using System;
using PRM_SALEORDERMAN.DAL;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.BLL
{
	public class InventoryBLL
	{
        private IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

        public List<InventoryML> getCurrentInventoryByListProduct() {
            List< InventoryML> result = new List<InventoryML>();
            InventoryDAL intDAL = new InventoryDAL(configuration);
            
                result = intDAL.getAllInvt(); result = intDAL.getAllInvt();result = intDAL.getAllInvt(); result = intDAL.getAllInvt();
            return result;
        }

    }
}


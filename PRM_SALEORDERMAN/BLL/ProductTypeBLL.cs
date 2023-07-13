using System;
using PRM_SALEORDERMAN.DAL;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.BLL
{
	public class ProductTypeBLL
	{
        private IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

        public List<ProductTypeML> getAllProductType() {
            ProductTypeDAL productTypeDAL = new ProductTypeDAL(configuration);
            List<ProductTypeML> listResult = productTypeDAL.getListProductType();
            if(listResult.Count <= 0) {
                listResult = null;
            }

            return listResult;

        }

    }
}


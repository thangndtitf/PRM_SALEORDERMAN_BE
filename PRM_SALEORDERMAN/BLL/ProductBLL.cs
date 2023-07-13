using System;
using PRM_SALEORDERMAN.DAL;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.BLL
{
	public class ProductBLL
	{
        private IConfiguration configuration = new ConfigurationBuilder()
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json")
       .Build();

        public List<ProductML> getAllProductML() {
            ProductDAL productDAL = new ProductDAL(configuration);
            List<ProductML> listResult = productDAL.getAllProduct();
            if(listResult.Count <= 0) {
                listResult = null;                   
            }

            return listResult;


            
        }
    }
}


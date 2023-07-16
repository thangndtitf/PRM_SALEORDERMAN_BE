using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PRM_SALEORDERMAN.BLL;
using PRM_SALEORDERMAN.ML;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PRM_SALEORDERMAN.Controllers
{
    [Route("api/product")]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        [Route("/getAllProduct")]
        public List<ProductML> getAllProduct() {
            ProductBLL productBLL = new ProductBLL();
            return productBLL.getAllProductML();
        }

        [HttpGet]
        [Route("/getProductByID/")]
        public ProductML getProductByID(int productID) {
            ProductBLL productBLL = new ProductBLL();
            return productBLL.getProductByID(productID);
        }

        [HttpGet]
        [Route("/getProductByType/")]
        public List<ProductML> getProductByType(int productType)
        {
            ProductBLL productBLL = new ProductBLL();
            return productBLL.getProductByType(productType);
        }
    }
}


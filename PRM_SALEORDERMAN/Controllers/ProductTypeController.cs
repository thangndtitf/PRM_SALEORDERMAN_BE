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
    [Route("api/productType")]
    public class ProductTypeController : ControllerBase
    {
        [HttpGet]
        [Route("/getAllProductType")]
        public List<ProductTypeML> getAllProductType() {
            ProductTypeBLL productTypeBLL = new ProductTypeBLL();
            return productTypeBLL.getAllProductType();
        }
    }
}


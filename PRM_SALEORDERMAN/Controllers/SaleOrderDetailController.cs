using Microsoft.AspNetCore.Mvc;
using PRM_SALEORDERMAN.BLL;
using PRM_SALEORDERMAN.ML;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PRM_SALEORDERMAN.Controllers
{
    [Route("api/SaleOrderDetail")]
    public class SaleOrderDetailController : ControllerBase
    {
        [HttpPost]
        [Route("/deleteProduct")]
        public Boolean deleteProductBySO([FromBody] int saleOrderDetailID)
        {
            SaleOrderDetailBLL saleOrderDetailBLL = new SaleOrderDetailBLL();
            return saleOrderDetailBLL.deleteProductBySO(saleOrderDetailID);
        }

        [HttpPost]
        [Route("/insertProductToSO")]
        public SaleOrderDetailML insertNewProductToSO([FromBody] SaleOrderDetailML saleOrderDetailML)
        {
            SaleOrderDetailBLL saleOrderDetailBLL = new SaleOrderDetailBLL();
            return saleOrderDetailBLL.insertProductToSO(saleOrderDetailML);
        }


        
    }
}



using Microsoft.AspNetCore.Mvc;
using PRM_SALEORDERMAN.BLL;
using PRM_SALEORDERMAN.ML;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PRM_SALEORDERMAN.Controllers
{
    [Route("api/v1/SaleOrder")]
    public class SaleOrdersController : ControllerBase
    {
        [HttpPost]
        [Route("/getSOByID")]
        public SaleOrderML getSOByID([FromBody]int saleOrderID)
        {   SaleOrderBLL saleOrderBLL = new SaleOrderBLL();
            return saleOrderBLL.getSaleOrderByID(saleOrderID);
        }

        [HttpGet]
        [Route("/getAllSP")]
        public List<SaleOrderML> getAllSO()
        {
            SaleOrderBLL saleOrderBLL = new SaleOrderBLL();
            return saleOrderBLL.getAllSaleOrder();
            
        }

        [HttpPost]
        [Route("/insertNewSO")]
        public int insertNewSaleOrder([FromBody] SaleOrderRequestBD requestBD)
        {
            SaleOrderBLL saleOrderBLL = new SaleOrderBLL();
            return saleOrderBLL.insertNewSaleOrder(requestBD.saleOrderML, requestBD.listSODetail); 
        }
    }
}


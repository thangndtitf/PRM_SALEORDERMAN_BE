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
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        [HttpPost]
        [Route("/getInforCustomer")]
        public CustomerML getInfoCusByID(int customerID)
        {
            CustomerBLL cusBLL = new CustomerBLL();
            return cusBLL.getCustomerInfo(customerID);
        }

        [HttpPost]
        [Route("/Login")]
        public CustomerML loginUP(String userName, String password)
        {
            CustomerBLL cusBLL = new CustomerBLL();
            return cusBLL.loginUP(userName, password);
        }
    }
}


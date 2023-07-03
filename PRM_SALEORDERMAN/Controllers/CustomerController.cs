﻿
using Microsoft.AspNetCore.Mvc;
using PRM_SALEORDERMAN.BLL;
using PRM_SALEORDERMAN.ML;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PRM_SALEORDERMAN.Controllers
{
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        [HttpGet]
        [Route("/getInforCustomer/{customerID}")]
        public CustomerML getInfoCusByID(int customerID)
        {
            CustomerBLL cusBLL = new CustomerBLL();
            return cusBLL.getCustomerInfo(customerID);
        }

        [HttpPost]
        [Route("/Login")]
        public CustomerML loginUP([FromBody] CustomerLoginRequest customerRequest)
        {
            CustomerBLL cusBLL = new CustomerBLL();
            return cusBLL.loginUP(customerRequest.userName, customerRequest.password);
        }
    }
}


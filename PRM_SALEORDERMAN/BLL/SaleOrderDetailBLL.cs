﻿using System;
using PRM_SALEORDERMAN.DAL;
using PRM_SALEORDERMAN.ML;

namespace PRM_SALEORDERMAN.BLL
{
	public class SaleOrderDetailBLL
	{
        private IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

        public List<SaleOrderDetailML> insertNewSaleOrderDetails(List<SaleOrderDetailML> listSODetail, int saleOrderID)
        {
            List<SaleOrderDetailML> listResult = new List<SaleOrderDetailML>();
            if(listSODetail.Count < 0)
            {
                throw new Exception("Error at insert new Saleorder Detail ");
            }
            else
            {
                SaleOrderDetailDAL saleOrderDetailDAL = new SaleOrderDetailDAL(configuration);
                for (int i = 0; i < listSODetail.Count; i++)
                {
                    listSODetail[i].saleOrderID = saleOrderID;
                    saleOrderDetailDAL.insertNewSaleOrderDetail(listSODetail[i]);
                    listResult.Add(listSODetail[i]);
                }
            }
            return listResult;
        }


    }
}


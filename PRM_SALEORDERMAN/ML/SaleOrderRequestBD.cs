using System;
namespace PRM_SALEORDERMAN.ML
{
	public class SaleOrderRequestBD
	{
		public SaleOrderML saleOrderML { get; set; }
		public List<SaleOrderDetailML> listSODetail { get; set; }

        public SaleOrderRequestBD(SaleOrderML saleOrderML, List<SaleOrderDetailML> listSODetail)
        {
            this.saleOrderML = saleOrderML;
            this.listSODetail = listSODetail;
        }
    }
}
using System;
namespace PRM_SALEORDERMAN.ML
{
	public class SaleOrderDetailML
	{
        public int saleOrderDetailID { get; set; }
        public int saleOrderID { get; set; }
        public int productID { get; set; }
        public int quantity { get; set; }
        public decimal totalPrice { get; set; }
        public decimal productPrice { get; set; }
        public decimal discountPrice { get; set; }

        public SaleOrderDetailML(int saleOrderDetailID, int saleOrder, int productID, int quantity, decimal totalPrice, decimal productPrice, decimal discountPrice)
        {
            this.saleOrderDetailID = saleOrderDetailID;
            this.saleOrderID = saleOrder;
            this.productID = productID;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
            this.productPrice = productPrice;
            this.discountPrice = discountPrice;
        }

        public SaleOrderDetailML(int saleOrder, int productID, int quantity, decimal totalPrice, decimal productPrice, decimal discountPrice)
        {
            this.saleOrderID = saleOrder;
            this.productID = productID;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
            this.productPrice = productPrice;
            this.discountPrice = discountPrice;
        }

        public SaleOrderDetailML()
        {
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeprojectExample.Contracts;
using CodeprojectExample.Models;

namespace CodeprojectExample.Models
{
    public class OnlineShoppingFacade
    {
        IInventory inventory = new InventoryManager();
        IOrderVerify orderVerify = new OrderVerificationManager();
        ICosting costManger = new CostManager();
        IPaymentGateway paymentGateWay = new PaymentGatewayManager();
        ILogistics logistics = new LogisticsManager();

        public void FinalizeOrder(OrderDetails orderDetails)
        {
            inventory.Update(orderDetails.ProductNo);
            orderVerify.VerifyShippingAddress(orderDetails.PinCode);
            orderDetails.Price = 
                costManger.ApplyDiscounts(orderDetails.Price, orderDetails.DiscountPercent);
            paymentGateWay.VerifyCardDetails(orderDetails.CardNo);
            paymentGateWay.ProcessPayment(orderDetails.CardNo, orderDetails.Price);
            logistics.ShipProduct(orderDetails.ProductName, string.Format("{0}, {1} - {2}.",
                                  orderDetails.AddressLine1, orderDetails.AddressLine2,
                                  orderDetails.PinCode));
        }

     }
}

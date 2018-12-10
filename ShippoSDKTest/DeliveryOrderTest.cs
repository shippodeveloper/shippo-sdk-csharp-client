using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippoSDK.Controllers;
using ShippoSDK.Models;
using ShippoSDK.Services;

namespace ShippoSDKTest
{
    [TestClass]
    public class DeliveryOrderTest : BaseTest
    {
        private DeliveryOrderService _deliveryOrderService;

        public DeliveryOrderTest()
        {
            _deliveryOrderService = new DeliveryOrderService(Config);
        }

        [TestMethod]
        public void DeliveryOrderTest1()
        {
            DeliveryOrderModel deliveryOrderModel = new DeliveryOrderModel();
//            deliveryOrderModel.pickupad
        }

        public PickupAddressModel CreatePickupAddress()
        {
            var pickupAddressService = new PickupAddressService(Config);
            var list = pickupAddressService.Get().Result;
            if (list.Count > 0) return list[0];

            var pickupAddressModel = new PickupAddressModel
            {
                ContactName = "Xuân Quỳnh",
                ContactPhone = "0987654321",
                Id = 11,
                DetailAddress = "Số 1 ngõ 2/12 Phố Ta"
            };

            var data = pickupAddressService.Create(pickupAddressModel).Result;
            return data;
        }
    }
}
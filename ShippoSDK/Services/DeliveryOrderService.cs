using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestEase;
using ShippoSDK.Interfaces;
using ShippoSDK.Models;
using ShippoSDK.Services;

namespace ShippoSDK.Controllers
{
    public class DeliveryOrderService : BaseService<IDeliveryOrder>
    {
        public DeliveryOrderService(ConfigModel configModel) : base(configModel)
        {
        }

        public async Task<DeliveryOrderModel> Create(DeliveryOrderModel param)
        {
            var response = await Api.Create(param);

            if (!Is2XxHttpStatus(response.ResponseMessage.StatusCode))
                throw new ShippoSdkException(response.StringContent);

            var deliveryOrder =
                JsonConvert.DeserializeObject<ResultModel<DeliveryOrderModel>>(response.StringContent);
            return deliveryOrder.Result;
        }

        public async Task<DeliveryOrderModel> Detail(long id)
        {
            var response = await Api.ReadOne(id);
            if (!Is2XxHttpStatus(response.ResponseMessage.StatusCode))
                throw new ShippoSdkException(response.StringContent);

            var deliveryOrder =
                JsonConvert.DeserializeObject<DeliveryOrderModel>(response.StringContent);
            return deliveryOrder;
        }

        public async Task<DeliveryOrderModel> Edit(int id, DeliveryOrderModel param)
        {
            var response = await Api.Update(id, param);

            if (!Is2XxHttpStatus(response.ResponseMessage.StatusCode))
                throw new ShippoSdkException(response.StringContent);

            var deliveryOrder =
                JsonConvert.DeserializeObject<DeliveryOrderModel>(response.StringContent);
            return deliveryOrder;
        }
    }
}
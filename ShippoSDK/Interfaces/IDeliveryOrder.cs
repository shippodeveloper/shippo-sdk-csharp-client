using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestEase;
using ShippoSDK.Models;

namespace ShippoSDK.Interfaces
{
    public interface IDeliveryOrder : IRestEase
    {
        [Post("/my/delivery_order")]
        [AllowAnyStatusCode]
        Task<Response<DeliveryOrderModel>> Create([Body] DeliveryOrderModel deliveryOrderModel);

        [Get("/my/delivery_order/{id}")]
        [AllowAnyStatusCode]
        Task<Response<DeliveryOrderModel>> ReadOne([Path] long id);

        [Patch("/my/delivery_order/{id}")]
        [AllowAnyStatusCode]
        Task<Response<DeliveryOrderModel>> Update([Path] int id, [Body] DeliveryOrderModel deliveryOrderModel);
    }
}
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestEase;
using ShippoSDK.Models;

namespace ShippoSDK.Interfaces
{
    public interface IPickupAddress : IRestEase
    {
        [Post("/my/pickup_address")]
        [AllowAnyStatusCode]
        Task<Response<PickupAddressModel>> Create([Body] PickupAddressModel pickupAddressModel);

        [Get("/my/pickup_addresses")]
        [AllowAnyStatusCode]
        Task<Response<string>> ReadAll();

        [Get("/my/pickup_address/{id}")]
        [AllowAnyStatusCode]
        Task<Response<PickupAddressModel>> ReadOne([Path] int id);

        [Patch("/my/pickup_address/{id}")]
        [AllowAnyStatusCode]
        Task<Response<PickupAddressModel>> Update([Path] int id, [Body] PickupAddressModel pickupAddressModel);

        [Delete("/my/pickup_address/{id}")]
        [AllowAnyStatusCode]
        Task<Response<PickupAddressModel>> Delete([Path] int id);
    }
}
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestEase;
using ShippoSDK.Models;

namespace ShippoSDK.Interfaces
{
    public interface ILocation : IRestEase
    {
        [Get("/config/locations")]
        [AllowAnyStatusCode]
        Task<Response<List<LocationModel>>> ReadByParams([Query(QuerySerializationMethod.Serialized)]
            LocationModel param);

        [Get("/config/location/{id}")]
        [AllowAnyStatusCode]
        Task<Response<LocationModel>> ReadOne([Path] int id);
    }
}
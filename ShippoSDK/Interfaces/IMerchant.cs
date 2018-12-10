using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestEase;
using ShippoSDK.Models;

namespace ShippoSDK.Interfaces
{
    public interface IMerchant : IRestEase
    {
        [Get("/my/profiles")]
        [AllowAnyStatusCode]
        Task<Response<MerchantModel>> ReadOne();
    }
}
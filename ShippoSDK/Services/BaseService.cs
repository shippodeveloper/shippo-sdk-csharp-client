using System.Net;
using System.Net.Http.Headers;
using RestEase;
using ShippoSDK.Interfaces;
using ShippoSDK.Models;

namespace ShippoSDK.Services
{
    public abstract class BaseService<TService> where TService : IRestEase
    {
        protected readonly ConfigModel ConfigModel;
        protected readonly TService Api;

        protected BaseService(ConfigModel configModel)
        {
            ConfigModel = configModel;
            Api = RestClient.For<TService>(ConfigModel.BaseUri);
            Api.Authorization = new AuthenticationHeaderValue("Basic", "Bearer " + ConfigModel.AccessToken);
            Api.ContentType = new MediaTypeHeaderValue("application/json");
        }

        protected bool Is2XxHttpStatus(HttpStatusCode statusCode)
        {
            return statusCode == HttpStatusCode.OK ||
                   statusCode == HttpStatusCode.Accepted ||
                   statusCode == HttpStatusCode.NonAuthoritativeInformation ||
                   statusCode == HttpStatusCode.NoContent ||
                   statusCode == HttpStatusCode.ResetContent ||
                   statusCode == HttpStatusCode.PartialContent;
        }
    }
}
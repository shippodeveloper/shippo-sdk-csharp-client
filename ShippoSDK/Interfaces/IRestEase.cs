using System;
using System.Net.Http.Headers;
using RestEase;

namespace ShippoSDK.Interfaces
{
    public interface IRestEase : IDisposable
    {
        [Header("Authorization")] AuthenticationHeaderValue Authorization { set; get; }
        [Header("Content-Type")] MediaTypeHeaderValue ContentType { get; set; }
    }
}
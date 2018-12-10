using System;
using Newtonsoft.Json;

namespace ShippoSDK.Models
{
    public class PickupAddressModel
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("merchantId")] public int MerchantId { get; set; }
        [JsonProperty("locationId")] public int LocationId { get; set; }

        [JsonProperty("contactName")] public string ContactName { get; set; }

        [JsonProperty("contactPhone")] public string ContactPhone { get; set; }

        [JsonProperty("detailAddress")] public string DetailAddress { get; set; }

        [JsonProperty("fullAddress")] public string FullAddress { get; set; }

        [JsonProperty("locationIdsPath")] public string LocationIdsPath { get; set; }

        [JsonProperty("version")] public int Version { get; set; }

        [JsonProperty("createdAt")] public DateTime? CreatedAt { get; set; }

        [JsonProperty("updatedAt")] public DateTime? UpdatedAt { get; set; }
    }
}
using System;
using Newtonsoft.Json;

namespace ShippoSDK.Models
{
    public class MerchantModel
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("code")] public string Code { get; set; }
        [JsonProperty("fullName")] public string FullName { get; set; }
        [JsonProperty("gender")] public int Gender { get; set; }
        [JsonProperty("mobile")] public string Mobile { get; set; }
        [JsonProperty("realBalance")] public float RealBalance { get; set; }
        [JsonProperty("avatar")] public string Avatar { get; set; }
        [JsonProperty("email")] public string Email { get; set; }
        [JsonProperty("isEmailVerified")] public bool IsEmailVerified { get; set; }
        [JsonProperty("state")] public string State { get; set; }
        [JsonProperty("bank")] public string[] Bank { get; set; }
        [JsonProperty("version")] public int Version { get; set; }
        [JsonProperty("createdAt")] public DateTime? CreatedAt { get; set; }
        [JsonProperty("firstOrderAt")] public DateTime? FirstOrderAt { get; set; }
        [JsonProperty("lastOrderAt")] public DateTime? LastOrderAt { get; set; }
        [JsonProperty("updateAt")] public DateTime? UpdateAt { get; set; }
    }
}
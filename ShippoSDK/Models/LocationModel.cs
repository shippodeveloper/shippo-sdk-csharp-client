using System;
using Newtonsoft.Json;

namespace ShippoSDK.Models
{
    public class LocationModel
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }

        [JsonProperty(PropertyName = "name")] public string Name { get; set; }

        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "level")] public int Level { get; set; }

        [JsonProperty(PropertyName = "parent_id")]
        public int ParentId { get; set; }

        [JsonProperty(PropertyName = "state")] public string State { get; set; }

        [JsonProperty(PropertyName = "lineage")]
        public string Lineage { get; set; }

        [JsonProperty(PropertyName = "code")] public string Code { get; set; }

        [JsonProperty(PropertyName = "priority")]
        public int Priority { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
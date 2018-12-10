using System;
using Newtonsoft.Json;

namespace ShippoSDK.Models
{
    public class ResultModel<TResult>
    {
        [JsonProperty("result")] public TResult Result { get; set; }
        [JsonIgnore]
        [JsonProperty("metaData")] public MetaData MetaData { get; set; }
        [JsonProperty("httpCode")] public int HttpCode { get; set; }
    }

    public class MetaData
    {
        [JsonProperty("pageSize")] public int PageSize { get; set; }
        [JsonProperty("currentPage")] public int CurrentPage { get; set; }
        [JsonProperty("totalRecords")] public int TotalRecords { get; set; }
        [JsonProperty("totalPages")] public int TotalPages { get; set; }
    }
}
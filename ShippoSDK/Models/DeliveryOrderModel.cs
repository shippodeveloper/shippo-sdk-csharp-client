using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShippoSDK.Models
{
    public class DeliveryOrderModel
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("merchantId")] public int MerchantId { get; set; }
        [JsonProperty("orderCode")] public string OrderCode { get; set; }
        [JsonProperty("merchantOrderCode")] public string MerchantOrderCode { get; set; }
        [JsonProperty("cod")] public float Cod { get; set; }
        [JsonProperty("realCod")] public float RealCod { get; set; }
        [JsonProperty("totalFee")] public float TotalFee { get; set; }
        [JsonProperty("fees")] public List<Fees> Fees { get; set; }

        [JsonProperty("services")] public string[] Services { get; set; }

        [JsonProperty("totalMerchantFee")] public float TotalMerchantFee { get; set; }
        [JsonProperty("weight")] public float Weight { get; set; }
        [JsonProperty("shift")] public string Shift { get; set; }
        [JsonProperty("merchantPrivateNote")] public string MerchantPrivateNote { get; set; }
        [JsonProperty("state")] public string State { get; set; }
        [JsonProperty("goods")] public string[] Goods { get; set; }
        [JsonProperty("trackingLink")] public string TrackingLink { get; set; }

        [JsonProperty("timeline")] public string[] Timeline { get; set; }

        [JsonProperty("metadata")] public string[] Metadata { get; set; }

        [JsonProperty("transitFailureNotes")] public string[] TransitFailureNotes { get; set; }

        [JsonProperty("createFromOrder")] public int CreateFromOrder { get; set; }

        [JsonProperty("pickupLocationIdsPath")]
        public string PickupLocationIdsPath { get; set; }

        [JsonProperty("pickupLocationNamesPath")]

        public string PickupLocationNamesPath { get; set; }

        [JsonProperty("pickupDetailAddress")] public string PickupDetailAddress { get; set; }
        [JsonProperty("pickupContact")] public string PickupContact { get; set; }
        [JsonProperty("pickupNote")] public string PickupNote { get; set; }

        [JsonProperty("deliverLocationIdsPath")]
        public string DeliverLocationIdsPath { get; set; }

        [JsonProperty("deliverLocationNamesPath")]

        public string DeliverLocationNamesPath { get; set; }

        [JsonProperty("deliverDetailAddress")] public string DeliverDetailAddress { get; set; }
        [JsonProperty("receiverName")] public string ReceiverName { get; set; }
        [JsonProperty("receiverPhone")] public string ReceiverPhone { get; set; }
        [JsonProperty("deliveryNote")] public string DeliveryNote { get; set; }
        [JsonProperty("deliveryPackage")] public string DeliveryPackage { get; set; }
        [JsonProperty("isReturn")] public bool IsReturn { get; set; }
        [JsonProperty("version")] public int Version { get; set; }
        [JsonProperty("createAt")] public DateTime? CreatedAt { get; set; }
        [JsonProperty("updateAt")] public DateTime? UpdatedAt { get; set; }
        [JsonProperty("preparePickupAt")] public DateTime? PreparePickupAt { get; set; }
        [JsonProperty("pickedUpAt")] public DateTime? PickedUpAt { get; set; }
        [JsonProperty("prepareDeliveryAt")] public DateTime? PrepareDeliveryAt { get; set; }
        [JsonProperty("startDeliveryAt")] public DateTime? StartDeliveryAt { get; set; }
        [JsonProperty("prepareRedeliveryAt")] public DateTime? PrepareRedeliveryAt { get; set; }
        [JsonProperty("failedDeliveryAt")] public DateTime? FailedDeliveryAt { get; set; }
        [JsonProperty("deliveryAt")] public DateTime? DeliveryAt { get; set; }
        [JsonProperty("deliveryCompletedAt")] public DateTime? DeliveryCompletedAt { get; set; }
        [JsonProperty("prepareReturnAt")] public DateTime? PrepareReturnAt { get; set; }
        [JsonProperty("startReturnAt")] public DateTime? StartReturnAt { get; set; }
        [JsonProperty("returnedAt")] public DateTime? ReturnedAt { get; set; }
        [JsonProperty("returnedCompletedAt")] public DateTime? ReturnedCompletedAt { get; set; }
        [JsonProperty("cancelledAt")] public DateTime? CancelledAt { get; set; }
    }

    public class Fees
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("feeCode")] public string FeeCode { get; set; }
        [JsonProperty("feeName")] public string FeeName { get; set; }
        [JsonProperty("feeGroup")] public string FeeGroup { get; set; }
        [JsonProperty("amount")] public float Amount { get; set; }
        [JsonProperty("chargeType")] public string ChargeType { get; set; }
        [JsonProperty("displayType")] public string DisplayType { get; set; }
        [JsonProperty("version")] public int Version { get; set; }
        [JsonProperty("lastestCalAt")] public DateTime LastestCalAt { get; set; }
        [JsonProperty("updatedAt")] public DateTime UpdatedAt { get; set; }
        [JsonProperty("isDeleted")] public bool IsDeleted { get; set; }
        [JsonProperty("isManual")] public bool IsManual { get; set; }
    }
}
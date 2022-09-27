#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using Newtonsoft.Json;

namespace LabelStore.Shipping.Api.Dto
{
    public class ShipmentDto
    {
        [JsonProperty(PropertyName = "id")]
        public Guid id { get; set; }


        [JsonProperty(PropertyName = "ShippingStatus")]
        public string ShippingStatus { get; set; }


        [JsonProperty(PropertyName = "OrderId")]
        public string OrderId { get; set; }

    }
}


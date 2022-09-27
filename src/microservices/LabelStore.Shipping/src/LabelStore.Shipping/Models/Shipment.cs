
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace LabelStore.Shipping.Api.Models
{
    public class Shipment
    {
        public Shipment()
        {
            id = Guid.NewGuid().ToString();
            ShippingStatus = "processing";
        }

        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [Required(ErrorMessage = "Provide the Id of the Shipping Service.")]
        [JsonProperty(PropertyName = "ShippingServiceId")]
        public string ShippingServiceId { get; set; }

        [Required(ErrorMessage = "Provide the Name of the Shipping Service.")]
        [JsonProperty(PropertyName = "ShippingServiceName")]
        public string ShippingServiceName { get; set; }

        [JsonProperty(PropertyName = "ShippingStatus")]
        public string ShippingStatus { get; set; }

        [Required(ErrorMessage = "Provide the Id of the Order.")]
        [JsonProperty(PropertyName = "OrderId")]
        public string OrderId { get; set; }

        [JsonProperty(PropertyName = "OrderDetails")]
        public List<OrderItem> OrderDetails { get; set; }

    }
}


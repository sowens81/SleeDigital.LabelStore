#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace LabelStore.Shipping.Api.Models
{
    public class OrderItem
    {
        [Required(ErrorMessage = "Product code of the Item.")]
        [JsonProperty(PropertyName = "ProductCode")]
        public string ProductCode { get; set; }

        [Required(ErrorMessage = "Name of the Item.")]
        [JsonProperty(PropertyName = "ItemName")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Qty of the item.")]
        [JsonProperty(PropertyName = "Qty")]
        public int Qty { get; set; }
    }
}


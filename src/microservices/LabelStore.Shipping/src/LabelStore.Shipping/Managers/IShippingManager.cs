using System;
using System.Reflection.Emit;
using LabelStore.Shipping.Api.Models;

namespace LabelStore.Shipping.Api.Managers
{
    public interface IShippingManager
    {
        Task<IEnumerable<Shipment>?> GetAllShipments();

        Task<Shipment?> GetShipmentAsync(string id);

        Task<string?> GetShippingStatusAsync(string id);

        // Task<string> SendShipmentAsync(NewShipment shippment);

        
    }
}




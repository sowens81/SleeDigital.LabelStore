using System;
using LabelStore.Shipping.Api.Models;
using LabelStore.Shipping.Api.Services;

namespace LabelStore.Shipping.Api.Managers.Implementation
{
    public class ShippingManager : IShippingManager
    {
        public readonly IDatabaseService _databaseService;

        public ShippingManager(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<IEnumerable<Shipment>?> GetAllShipments()
        {
            var sqlCosmosQuery = "Select * from s";
            var response = await _databaseService.GetAllRecordsAsync(sqlCosmosQuery);

            if (response == null)
            {
                return null;
            }
            return response;
        }

        public async Task<Shipment?> GetShipmentAsync(string id)
        {
            var response = await _databaseService.GetRecordAsync(id);

            if (response == null)
            {
                return null;
            }
            return response;
        }

        public async Task<string?> GetShippingStatusAsync(string id)
        {
            var response = await _databaseService.GetRecordAsync(id);

            if (response == null)
            {
                return null;
            }

            return response.ShippingStatus;
        }

    }
}


using System;
using LabelStore.Shipping.Api.Models;

namespace LabelStore.Shipping.Api.Services
{
    public interface IDatabaseService
    {
        Task<IEnumerable<Shipment>?> GetAllRecordsAsync(string queryString);

        Task<Shipment?> GetRecordAsync(string id);

        Task<Shipment?> AddRecordAsync(Shipment shipment);

    }
}


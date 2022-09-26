using System;
using LabelStore.Shipping.Models;

namespace LabelStore.Shipping.Api.Services
{
    public interface IQueueService
    {
        Task<bool> AddMessageAsync(Shipment shipment);
    }
}


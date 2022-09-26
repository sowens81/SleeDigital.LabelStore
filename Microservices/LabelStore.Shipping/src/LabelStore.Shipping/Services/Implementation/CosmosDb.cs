using System;
using System.Reflection.Emit;
using Azure;
using LabelStore.Shipping.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Cosmos;

namespace LabelStore.Shipping.Api.Services.Implementation
{
    public class CosmosDb : IDatabaseService
    {
        private readonly Container _container;

        public CosmosDb(
            CosmosClient cosmosDbClient,
            string databaseName,
            string containerName)
        {
            _container = cosmosDbClient.GetContainer(databaseName, containerName);
        }
    
        public async Task<IEnumerable<Shipment>?> GetAllRecordsAsync(string queryString)
        {
            try
            {
                var query = _container.GetItemQueryIterator<Shipment>(new QueryDefinition(queryString));
                var shipments = new List<Shipment>();
                while (query.HasMoreResults)
                {
                    var response = await query.ReadNextAsync();
                    shipments.AddRange(response.ToList());
                }

                return shipments;
            }
            catch (CosmosException)
            {
                return null;
            }

        }

        public async Task<Shipment?> GetRecordAsync(string id)
        {
            try
            {
                var reponse = await _container.ReadItemAsync<Shipment>(id, new PartitionKey(id));
                return reponse.Resource;
            }
            catch (CosmosException) 
            {
                return null;
            }
        }

        public async Task<Shipment?> AddRecordAsync(Shipment shipment)
        {
            try
            {
                var response = await _container.CreateItemAsync(shipment, new PartitionKey(shipment.id));
                return response.Resource;

            }
            catch (CosmosException)
            {
                return null;
            }

        }
    }
}


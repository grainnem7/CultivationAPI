using ContosoWebAPI.Models;
using Microsoft.Azure.Cosmos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoWebAPI.Services
{
    public class CosmosDbService : ICosmosDBService
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient cosmosDbClient,
            string databaseName,
            string containerName)
        {
            _container = cosmosDbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddAsync(PondModel pond)
        {
            await _container.CreateItemAsync(pond);
        }

        public async Task DeleteAsync(string id)
        {
            await _container.DeleteItemAsync<PondModel> (id, new PartitionKey(id));
        }

        public async Task<PondModel> GetAsync(string id)
        {
            try
            {
                var response = await _container.ReadItemAsync<PondModel>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException) //For handling pond not found and other exceptions
            {
                return null;
            }
        }

        public async Task<IEnumerable<PondModel>> GetMultipleAsync(string queryString)
        {
            var query = _container.GetItemQueryIterator<PondModel>(new QueryDefinition(queryString));

            var results = new List<PondModel>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateAsync(string partitionKey, PondModel pond)
        {
            await _container.UpsertItemAsync(pond, new PartitionKey(partitionKey));
        }
    }
}

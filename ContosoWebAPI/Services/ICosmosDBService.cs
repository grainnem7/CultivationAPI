using ContosoWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContosoWebAPI.Services
{
    public interface ICosmosDBService
    {
        Task<IEnumerable<PondModel>> GetMultipleAsync(string query);
        Task<PondModel> GetAsync(string id);
        Task AddAsync(PondModel pond);
        Task UpdateAsync(string id, PondModel pond);
        Task DeleteAsync(string id);
    }
}

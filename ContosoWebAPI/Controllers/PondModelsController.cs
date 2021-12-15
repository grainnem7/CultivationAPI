using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContosoWebAPI.Models;
using ContosoWebAPI.Services;

namespace ContosoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PondModelsController : ControllerBase
    {
        private readonly ICosmosDBService _cosmosDBService;

        public PondModelsController(ICosmosDBService cosmosDBService)
        {
            _cosmosDBService = cosmosDBService;
        }

        [HttpGet]
        public async Task<IEnumerable<PondModel>> Get()
        {
            return await _cosmosDBService.GetMultipleAsync("SELECT * FROM c");
        }

        /*
        // GET api/items
        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _cosmosDBService.GetMultipleAsync("SELECT * FROM c"));
        }
        */

        // GET api/PondModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            //return Ok(await _cosmosDBService.GetAsync(id));
            return Ok(await _cosmosDBService.GetMultipleAsync("SELECT * FROM c where c.id = '" + id + "'"));

        }
        // POST api/items
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PondModel pond)
        {
            pond.id = Guid.NewGuid().ToString();
            await _cosmosDBService.AddAsync(pond);
            return CreatedAtAction(nameof(Get), new { id = pond.id }, pond);
        }

        // PUT api/PondModels/5
        // Cannot update id as it is Primary Key? Creates new pond if id updated
        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] PondModel pond, string newLocation)
        {
            //await _cosmosDBService.UpdateAsync(pond.id, pond);
            //var document = _cosmosDBService.GetAsync();
            //document.Location = newLocation
            await _cosmosDBService.UpdateAsync(pond.pondCode, pond);

            return NoContent();
        }
        // DELETE api/PondModels/id/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            //await _cosmosDBService.DeleteAsync(id);
           await _cosmosDBService.DeleteAsync("SELECT * FROM c where c.id = '" + id + "'");
            return NoContent();
        }
    }
}

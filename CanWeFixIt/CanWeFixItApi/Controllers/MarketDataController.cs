using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CanWeFixItApi.Controllers
{
    [ApiController]
    [Route("v1/marketdata")]
    public class MarketDataController : ControllerBase
    {
          _database = database;
        public async Task<ActionResult<IEnumerable<MarketDataDto>>> Get()
        {
            return Ok(_database.Instruments().Result);

            return NotFound();
        }
    }
}

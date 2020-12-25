using EHWR.Domain.DomainModel.Locality;
using EHWR.Services.Interfaces.Locality;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.Controllers.Locality
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocalityController : ControllerBase
    {
        private readonly ILocalityService _localityService;

        public LocalityController(ILocalityService localityService)
        {
            _localityService = localityService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] LocalitySearch localitySearch)
        {
            IEnumerable<LocalityModel> collection = await _localityService.LocalityAsync(localitySearch);

            return Ok(collection);
        }
    }
}

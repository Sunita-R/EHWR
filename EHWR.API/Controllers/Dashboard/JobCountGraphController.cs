using EHWR.Domain.DomainModel.Dashboard;
using EHWR.Services.Interfaces.Dashboard;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.Controllers.Dashboard
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobCountGraphController : ControllerBase
    {
        private readonly IJobCountGraphService _jobCountGraphService;
        public JobCountGraphController(IJobCountGraphService jobCountGraphService)
        {
            _jobCountGraphService = jobCountGraphService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            IEnumerable<JobsCountGraphModel> collection = await _jobCountGraphService.CollectionAsync();
            return Ok(collection);
        }


    }
}

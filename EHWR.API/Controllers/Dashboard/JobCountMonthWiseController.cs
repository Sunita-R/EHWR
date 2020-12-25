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
    public class JobCountMonthWiseController : ControllerBase
    {
        private readonly IJobCountMonthWiseService _jobCountMonthWiseService;
        public JobCountMonthWiseController(IJobCountMonthWiseService jobCountMonthWiseService)
        {
            _jobCountMonthWiseService = jobCountMonthWiseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            IEnumerable<JobCountMonthWiseModel> collection = await _jobCountMonthWiseService.CollectionAsync();
            return Ok(collection);
        }
    }
}

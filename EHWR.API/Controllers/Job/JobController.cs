using EHWR.API.DTO.Job;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Job;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EHWR.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;
        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] JobSearch jobSearch)
        {
            IEnumerable<JobModel> collection = await _jobService.CollectionAsync(jobSearch);
                return Ok(collection);
        }

        [HttpDelete]
        
        public async Task<IActionResult> Delete([FromQuery] Delete delete)
        {
            SpResponse JobDeleted = await _jobService.DeleteJob(delete);
            return Ok(JobDeleted);
        }

        [HttpPost]

        public async Task<IActionResult> POST(AddJobOrderDTO addJobOrderDTO)
        {
            SpResponse JobAdded = await _jobService.AddJob(addJobOrderDTO);
            return Ok(JobAdded);
        }

        [HttpPut]

        public async Task<IActionResult> Put(UpdateJobDTO model)
        {
            SpResponse UpdatedJob = await _jobService.UpdateJob(model);
            return Ok(UpdatedJob);
        }
        [HttpPut("MoveJob")]
        public async Task<IActionResult> MoveJob(SearchMoveJob model)
        {
            SpResponse updatedJob = await _jobService.MoveJob(model);
            return Ok(updatedJob);
        }
    }
}

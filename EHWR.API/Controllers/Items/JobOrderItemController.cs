using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Items;
using EHWR.Domain.DTO.Items;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Items;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.Controllers.Items
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobOrderItemController : ControllerBase
    {
        private readonly IJobOrderItemService _jobOrderItemService;

        public JobOrderItemController(IJobOrderItemService jobOrderItemService)
        {
           
            _jobOrderItemService = jobOrderItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] ItemSearch itemSearch)
        {
            IEnumerable<JobOrderItemModel> collection = await _jobOrderItemService.CollectionAsync(itemSearch);
            return Ok(collection);
        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromQuery] Delete delete)
        {
            SpResponse ItemDeleted = await _jobOrderItemService.DeleteItem(delete);
            return Ok(ItemDeleted);
        }
        [HttpPost]
        public async Task<IActionResult> Post(AddJobOrderItemsDTO model)
        {
            SpResponse addJobOrderItem = await _jobOrderItemService.AddJobOrderItemAsync(model);
            return Ok(addJobOrderItem);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateJobOrderItemDto model)
        {
            SpResponse UpdatedJobOrder = await _jobOrderItemService.UpdateJob(model);
            return Ok(UpdatedJobOrder);
        }

    }
}

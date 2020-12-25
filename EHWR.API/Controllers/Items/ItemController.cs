using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Items;
using EHWR.Domain.DTO.Items;
using EHWR.Domain.Response;
using EHWR.Services.Concrete.Items;
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
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }
        [HttpGet]
        public async Task<IActionResult> GetListAsync([FromQuery] SearchItem searchItem)
        {
            IEnumerable<ItemModel> collection = await _itemService.GetItemListAnync(searchItem);
            return Ok(collection);
            
        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromQuery] Delete delete)
        {
            SpResponse itemDelete = await _itemService.DeleteItemAsync(delete);
            return Ok(itemDelete);
        }


        [HttpPost]
        public async Task<IActionResult> Post(AddItemDTO model)
        {
            SpResponse addItem = await _itemService.AddItemAsync(model);
            return Ok(addItem);
        }
        [HttpPut]
        public async Task<IActionResult> Put(UpdateItemDTO model)
        {
            SpResponse updateItem = await _itemService.UpdateItemAsync(model);
            return Ok(updateItem);
        }

    }
}

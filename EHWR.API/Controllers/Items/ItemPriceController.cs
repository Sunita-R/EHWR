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
    public class ItemPriceController : ControllerBase
    {
        private readonly IItemPriceService _itemPriceService;

        public ItemPriceController(IItemPriceService itemPriceService)
        {
            _itemPriceService = itemPriceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetItemPriceAsync([FromQuery] SearchItemPrice searchItemPrice)
        {
            IEnumerable<ItemPriceModel> collection = await _itemPriceService.GetItemPriceAsync(searchItemPrice);
            return Ok(collection);
        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromQuery] Delete delete)
        {
            SpResponse deleteItemPrice = await _itemPriceService.DeleteItemPriceAsync(delete);
            return Ok(deleteItemPrice);
        }


        [HttpPost]
        public async Task<IActionResult> Post(AddItemPriceDTO model)
        {
            SpResponse addItemPrice = await _itemPriceService.AddItemPriceAsync(model);
            return Ok(addItemPrice);
        }
        [HttpPut]
        public async Task<IActionResult> Put(UpdateItemPriceDTO model)
        {
            SpResponse updateItemPrice = await _itemPriceService.UpdateItemPriceAsync(model);
            return Ok(updateItemPrice);
        }
    }
}

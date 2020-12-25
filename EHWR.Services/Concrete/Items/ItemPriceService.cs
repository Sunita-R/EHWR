using EHWR.Domain.BusinessRules.Items;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Items;
using EHWR.Domain.DTO.Items;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Items
{
    public class ItemPriceService : IItemPriceService
    {
        private readonly IItemPriceRepository _itemPriceRepository;

        public ItemPriceService(IItemPriceRepository itemPriceRepository)
        {
            _itemPriceRepository = itemPriceRepository;
        }

        public async Task<SpResponse> AddItemPriceAsync(AddItemPriceDTO addItemPriceDTO)
        {
            return await _itemPriceRepository.AddItemPriceAsync(addItemPriceDTO);
        }

        public async Task<SpResponse> DeleteItemPriceAsync(Delete delete)
        {
            return await _itemPriceRepository.DeleteItemPriceAsync(delete);
        }

        public async Task<IEnumerable<ItemPriceModel>> GetItemPriceAsync(SearchItemPrice searchItemPrice)
        {
            return await _itemPriceRepository.GetItemPriceAsync(searchItemPrice);
        }

        public async Task<SpResponse> UpdateItemPriceAsync(UpdateItemPriceDTO updateItePricemDTO)
        {
            return await _itemPriceRepository.UpdateItemPriceAsync(updateItePricemDTO);
        }
    }
}

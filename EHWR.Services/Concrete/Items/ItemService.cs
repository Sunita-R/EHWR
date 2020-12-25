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
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<SpResponse> AddItemAsync(AddItemDTO addItemDTO)
        {
            return await _itemRepository.AddItemAsync(addItemDTO);
        }

        public async Task<SpResponse> DeleteItemAsync(Delete delete)
        {
            return await _itemRepository.DeleteItemAsync(delete);
        }

        public async Task<IEnumerable<ItemModel>> GetItemListAnync(SearchItem searchItem)
        {
            return await _itemRepository.GetItemListAsync(searchItem);
        }

        public async Task<SpResponse> UpdateItemAsync(UpdateItemDTO updateItemDTO)
        {
            return await _itemRepository.UpdateItemAsync(updateItemDTO);
        }
    }
}

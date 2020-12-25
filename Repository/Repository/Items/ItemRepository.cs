using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Items;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Items;
using EHWR.Domain.DTO.Items;
using EHWR.Domain.Response;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Items
{
    public class ItemRepository : GenericRepository, IItemRepository
    {
        public ItemRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<SpResponse> AddItemAsync(AddItemDTO addItemDTO)
        {
            return await CommandAsync<SpResponse>("AddItem", addItemDTO);
        }

        public async Task<SpResponse> DeleteItemAsync(Delete delete)
        {
            return await CommandAsync<SpResponse>("DeleteItem", delete);
        }

        public async Task<IEnumerable<ItemModel>> GetItemListAsync(SearchItem searchItem)
        {
            return await CollectionsAsync<ItemModel>("GetItemList", searchItem);
        }

        public async Task<SpResponse> UpdateItemAsync(UpdateItemDTO updateItemDTO)
        {
            return await CommandAsync<SpResponse>("UpdateItem", updateItemDTO);
        }
    }
}

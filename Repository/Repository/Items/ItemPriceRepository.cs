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
    public class ItemPriceRepository : GenericRepository, IItemPriceRepository
    {
        public ItemPriceRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<SpResponse> AddItemPriceAsync(AddItemPriceDTO addItemPriceDTO)
        {
            return await CommandAsync<SpResponse>("AddItemPrice", addItemPriceDTO);
        }

        public async Task<SpResponse> DeleteItemPriceAsync(Delete delete)
        {
            return await CommandAsync<SpResponse>("DeleteItemPrice", delete);
        }

        public async Task<IEnumerable<ItemPriceModel>> GetItemPriceAsync(SearchItemPrice searchItemPrice)
        {
            return await CollectionsAsync<ItemPriceModel>("GetItemPriceList", searchItemPrice);
        }

        public async Task<SpResponse> UpdateItemPriceAsync(UpdateItemPriceDTO updateItePricemDTO)
        {
            return await CommandAsync<SpResponse>("UpdateItemPrice", updateItePricemDTO);
        }
    }
}

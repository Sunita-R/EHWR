using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Items;
using EHWR.Domain.DTO.Items;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces.Items
{
    public interface IItemPriceService
    {
        Task<IEnumerable<ItemPriceModel>> GetItemPriceAsync(SearchItemPrice searchItemPrice);
        Task<SpResponse> AddItemPriceAsync(AddItemPriceDTO addItemPriceDTO);
        Task<SpResponse> UpdateItemPriceAsync(UpdateItemPriceDTO updateItePricemDTO);
        Task<SpResponse> DeleteItemPriceAsync(Delete delete);
    }
}

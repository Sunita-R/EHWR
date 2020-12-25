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
    public interface IItemService
    {
        Task<IEnumerable<ItemModel>> GetItemListAnync(SearchItem searchItem);

        Task<SpResponse> AddItemAsync(AddItemDTO addItemDTO);

        Task<SpResponse> UpdateItemAsync(UpdateItemDTO updateItemDTO);
        Task<SpResponse> DeleteItemAsync(Delete delete);

    }
}

using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Items;
using EHWR.Domain.DTO.Items;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules.Items
{
    public interface IJobOrderItemRepository
    {
        Task<IEnumerable<JobOrderItemModel>> CollectionAsync(ItemSearch itemSearch);
        Task<SpResponse> AddJobOrderItemAsync(AddJobOrderItemsDTO addJobOrderItemsDTO);
        Task<SpResponse> DeleteItem(Delete delete);
        Task<SpResponse> UpdateJob(UpdateJobOrderItemDto UpdateJobOrderItemDto);
    }
}

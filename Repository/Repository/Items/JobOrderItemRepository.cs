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
    public class JobOrderItemRepository : GenericRepository, IJobOrderItemRepository
    {
        public JobOrderItemRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<SpResponse> UpdateJob(UpdateJobOrderItemDto UpdateJobOrderItemDto)
        {
            return await CommandAsync<SpResponse>("UpdateJobOrderItem", UpdateJobOrderItemDto);
        }
        public async Task<IEnumerable<JobOrderItemModel>> CollectionAsync(ItemSearch itemSearch)
        {
            return await CollectionsAsync<JobOrderItemModel>("GetJobOrderItemList", itemSearch);
        }

        public async Task<SpResponse> DeleteItem(Delete delete)
        {
            return await CommandAsync<SpResponse>("DeleteJobOrderItems", delete);
        }

        public async Task<SpResponse> AddJobOrderItemAsync(AddJobOrderItemsDTO addJobOrderItemsDTO)
        {
            return await CommandAsync<SpResponse>("AddJobOrderItem", addJobOrderItemsDTO);
        }
    }
}

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
    public class JobOrderItemService : IJobOrderItemService
    {
        private readonly IJobOrderItemRepository _jobOrderItemRepository;

        public JobOrderItemService(IJobOrderItemRepository jobOrderItemRepository)
        {
            _jobOrderItemRepository = jobOrderItemRepository;
        }
        public async Task<SpResponse> UpdateJob(UpdateJobOrderItemDto updateJobOrderItemDto)
        {
            return await _jobOrderItemRepository.UpdateJob(updateJobOrderItemDto);
        }
        public async Task<IEnumerable<JobOrderItemModel>> CollectionAsync(ItemSearch itemSearch)
        {
            return await _jobOrderItemRepository.CollectionAsync(itemSearch);
        }

        public async Task<SpResponse> DeleteItem(Delete delete)
        {
            return await _jobOrderItemRepository.DeleteItem(delete);
        }

        public async Task<SpResponse> AddJobOrderItemAsync(AddJobOrderItemsDTO addJobOrderItemsDTO)
        {
            return await _jobOrderItemRepository.AddJobOrderItemAsync(addJobOrderItemsDTO);
        }
    }
}
using EHWR.API.DTO.Job;
using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Job;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Job;
using EHWR.Domain.Response;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class JobRepository : GenericRepository, IJobRepository
    {
        public JobRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<JobModel>> CollectionAsync(JobSearch jobSearch)
        {
            return await CollectionsAsync<JobModel>("GetJobList", jobSearch);
        }

        public async Task<SpResponse> DeleteJob(Delete delete)
        {
            return await CommandAsync<SpResponse>("DeleteJobOrders", delete);
        }

        public async Task<SpResponse> AddJob(AddJobOrderDTO addJobOrderDTO)
        {
            return await CommandAsync<SpResponse>("AddJobOrders", addJobOrderDTO);
        }

        public async Task<SpResponse> UpdateJob(UpdateJobDTO updateJobDTO)
        {
            return await CommandAsync<SpResponse>("UpdateJobOrders", updateJobDTO);
        }

        public async Task<SpResponse> MoveJob(SearchMoveJob searchMoveJob)
        {
            return await CommandAsync<SpResponse>("sp_MoveCustomerJob", searchMoveJob);
        }
    }
}

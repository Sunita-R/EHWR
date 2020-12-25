using EHWR.API.DTO.Job;
using EHWR.Domain.BusinessRules.Job;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Job;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<SpResponse> AddJob(AddJobOrderDTO addJobOrderDTO)
        {
            return await _jobRepository.AddJob(addJobOrderDTO);
            
        }

        public async Task<IEnumerable<JobModel>> CollectionAsync(JobSearch jobSearch)
        {
            return await _jobRepository.CollectionAsync(jobSearch);
        }

        public async Task<SpResponse> DeleteJob(Delete delete)
        {
            return await _jobRepository.DeleteJob(delete);
        }

        public async Task<SpResponse> MoveJob(SearchMoveJob searchMoveJob)
        {
            return await _jobRepository.MoveJob(searchMoveJob);
        }

        public async Task<SpResponse> UpdateJob(UpdateJobDTO updateJobDTO)
        {
            return await _jobRepository.UpdateJob(updateJobDTO);
        }
    }
}

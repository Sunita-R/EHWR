using EHWR.API.DTO.Job;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Job;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules.Job
{
    public interface IJobRepository
    {
        Task<IEnumerable<JobModel>> CollectionAsync(JobSearch jobSearch);

        Task<SpResponse> DeleteJob(Delete delete);

        Task<SpResponse> AddJob(AddJobOrderDTO addJobOrderDTO);

        Task<SpResponse> UpdateJob(UpdateJobDTO updateJobDTO );
        Task<SpResponse> MoveJob(SearchMoveJob searchMoveJob);
    }
}

using EHWR.Domain.BusinessRules.Dashboard;
using EHWR.Domain.DomainModel.Dashboard;
using EHWR.Services.Interfaces.Dashboard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Dashboard
{
    public class JobCountGraphService : IJobCountGraphService
    {

        private readonly IJobCountGraphRepository _jobCountGraphRepository;
        public JobCountGraphService(IJobCountGraphRepository jobCountGraphRepository)
        {
            _jobCountGraphRepository = jobCountGraphRepository;
        }
        public async Task<IEnumerable<JobsCountGraphModel>> CollectionAsync()
        {
            return await _jobCountGraphRepository.CollectionAsync();
        }
    }


}

using EHWR.Domain.BusinessRules.Dashboard;
using EHWR.Domain.DomainModel.Dashboard;
using EHWR.Services.Interfaces.Dashboard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Dashboard
{
    public class JobCountMonthWiseService : IJobCountMonthWiseService
    {
        private readonly IJobCountMonthWiseRepository _jobCountMonthWiseRepository;
        public JobCountMonthWiseService(IJobCountMonthWiseRepository jobCountMonthWiseRepository)
        {
            _jobCountMonthWiseRepository = jobCountMonthWiseRepository;
        }
        public async  Task<IEnumerable<JobCountMonthWiseModel>> CollectionAsync()
        {
            return await _jobCountMonthWiseRepository.CollectionAsync();

        }
    }
}

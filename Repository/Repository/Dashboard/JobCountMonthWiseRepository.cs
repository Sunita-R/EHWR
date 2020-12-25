using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Dashboard;
using EHWR.Domain.DomainModel.Dashboard;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Dashboard
{
    public class JobCountMonthWiseRepository : GenericRepository, IJobCountMonthWiseRepository
    {
        public JobCountMonthWiseRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<JobCountMonthWiseModel>> CollectionAsync()
        {
            return await CollectionsAsync<JobCountMonthWiseModel>("sp_GetJobCountMonthWise");
        }
    }
}

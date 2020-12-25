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
    public class JobCountGraphRepository : GenericRepository, IJobCountGraphRepository
    {
        public JobCountGraphRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<JobsCountGraphModel>> CollectionAsync()
        {
            return await CollectionsAsync<JobsCountGraphModel>("sp_GetJobCountWithAmountMonthWise");
        }
    }
}

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
    public class DashboardRepository : GenericRepository, IDashboardRepository
    {
        public DashboardRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<IEnumerable<DashboardModel>> CollectionAsync(DashboardSearch dashboardSearch)
        {
            return await CollectionsAsync<DashboardModel>("DashboardSearch", dashboardSearch);
        }
    }
}

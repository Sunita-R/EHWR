using EHWR.Domain.BusinessRules.Dashboard;
using EHWR.Domain.DomainModel.Dashboard;
using EHWR.Services.Interfaces.Dashboard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Dashboard
{
    public class DashboardService : IDashboardService
    {
        private readonly IDashboardRepository _dashboardRepository;
        public DashboardService(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }
        public async Task<IEnumerable<DashboardModel>> CollectionAsync(DashboardSearch dashboardSearch)
        {
            return await _dashboardRepository.CollectionAsync(dashboardSearch);
        }
    }
}

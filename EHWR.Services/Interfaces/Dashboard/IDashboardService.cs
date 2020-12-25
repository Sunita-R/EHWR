using EHWR.Domain.DomainModel.Dashboard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces.Dashboard
{
    public interface IDashboardService
    {
        Task<IEnumerable<DashboardModel>> CollectionAsync(DashboardSearch dashboardSearch);

    }
}

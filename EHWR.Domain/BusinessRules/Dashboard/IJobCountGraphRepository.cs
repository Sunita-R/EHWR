using EHWR.Domain.DomainModel.Dashboard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules.Dashboard
{
    public interface IJobCountGraphRepository
    {
        Task<IEnumerable<JobsCountGraphModel>> CollectionAsync();

    }
}

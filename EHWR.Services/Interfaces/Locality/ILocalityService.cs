using EHWR.Domain.DomainModel.Locality;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces.Locality
{
    public interface ILocalityService
    {
        Task<IEnumerable<LocalityModel>> LocalityAsync(LocalitySearch localitySearch);
    }
}

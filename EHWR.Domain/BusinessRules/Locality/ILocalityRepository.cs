using EHWR.Domain.DomainModel.Locality;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules.Locality
{
    public interface ILocalityRepository
    {
         Task<IEnumerable<LocalityModel>> LocalityAsync(LocalitySearch  localitySearch);
    }
}

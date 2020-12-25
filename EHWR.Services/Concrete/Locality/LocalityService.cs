using EHWR.Domain.BusinessRules.Locality;
using EHWR.Domain.DomainModel.Locality;
using EHWR.Services.Interfaces.Locality;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Locality
{
    public class LocalityService : ILocalityService
    {
        private readonly ILocalityRepository _localityRepository;

        public LocalityService(ILocalityRepository localityRepository)
        {
            _localityRepository = localityRepository;
        }

        public async Task<IEnumerable<LocalityModel>> LocalityAsync(LocalitySearch localitySearch)
        {
            return await _localityRepository.LocalityAsync(localitySearch);
        }
    }
}

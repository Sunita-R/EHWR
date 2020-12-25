using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Locality;
using EHWR.Domain.DomainModel.Locality;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Locality
{
    public class LocalityRepository : GenericRepository, ILocalityRepository
    {
        public LocalityRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<LocalityModel>> LocalityAsync(LocalitySearch localitySearch)
        {
            return await CollectionsAsync<LocalityModel>("GetLocality", localitySearch);
        }
    }
}

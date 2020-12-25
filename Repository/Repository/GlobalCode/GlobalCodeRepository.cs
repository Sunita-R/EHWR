using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.GlobalCode;
using EHWR.Domain.DomainModel.GlobalCode;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.GlobalCode
{
    public class GlobalCodeRepository : GenericRepository, IGlobalCodeRepository
    {
        public GlobalCodeRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<GlobalCodeCategoriesModel>> GlobalCodeCategoriesAsync()
        {
            return await CollectionsAsync<GlobalCodeCategoriesModel>("GetGlobalCodeCategories");
        }

        public async Task<IEnumerable<GlobalCodeModel>> GlobalCodeListAnync(GlobelSearchModel globelSearchModel)
        {
            return await CollectionsAsync<GlobalCodeModel>("GetGlobalCode", globelSearchModel);
        }
    }
}

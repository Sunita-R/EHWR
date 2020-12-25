using EHWR.Domain.BusinessRules.GlobalCode;
using EHWR.Domain.DomainModel.GlobalCode;
using EHWR.Services.Interfaces.GlobalCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.GlobalCode
{
    public class GlobalCodeService : IGlobalCodeService
    {
        private readonly IGlobalCodeRepository _globalCodeRepository;

        public GlobalCodeService(IGlobalCodeRepository globalCodeRepository)
        {
            _globalCodeRepository = globalCodeRepository;
        }

        public async Task<IEnumerable<GlobalCodeCategoriesModel>> GlobalCodeCategoriesAsync()
        {
            return await _globalCodeRepository.GlobalCodeCategoriesAsync();
        }

        public async Task<IEnumerable<GlobalCodeModel>> GlobalCodeListAnync(GlobelSearchModel globelSearchModel)
        {
            return await _globalCodeRepository.GlobalCodeListAnync(globelSearchModel);

        }

    }
}

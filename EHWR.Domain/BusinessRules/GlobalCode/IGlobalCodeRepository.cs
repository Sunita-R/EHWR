using EHWR.Domain.DomainModel.GlobalCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static EHWR.Domain.DomainModel.GlobalCode.GlobalCodeModel;

namespace EHWR.Domain.BusinessRules.GlobalCode
{
    public interface IGlobalCodeRepository
    {
        Task<IEnumerable<GlobalCodeModel>> GlobalCodeListAnync(GlobelSearchModel globelSearchModel);

        Task<IEnumerable<GlobalCodeCategoriesModel>> GlobalCodeCategoriesAsync();
    }
}

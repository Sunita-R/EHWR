using EHWR.Domain.DomainModel.GlobalCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces.GlobalCode
{
    public interface IGlobalCodeService
    {
        Task<IEnumerable<GlobalCodeModel>> GlobalCodeListAnync(GlobelSearchModel globelSearchModel);
        Task<IEnumerable<GlobalCodeCategoriesModel>> GlobalCodeCategoriesAsync();
    }
}

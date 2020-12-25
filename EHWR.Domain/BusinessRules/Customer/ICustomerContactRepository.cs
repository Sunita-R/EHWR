using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Customer;
using EHWR.Domain.DTO.Customer;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules.Customer
{
    public interface ICustomerContactRepository
    {
        Task<IEnumerable<CustomerContactModel>> CustomerContactListAsync(CustomerContactSearch customerContactSearch);
        Task<SpResponse> AddCustomerContactAsync(CustomerContactDTO customerContactDTO);
        Task<SpResponse> UpdateCustomerContactAsync(CustomerContactUpdateDTO customerContactUpdateDTO);
        Task<SpResponse> DeleteCustomerContactAsync(Delete delete);
    }
}

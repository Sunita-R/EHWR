using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Customer;
using EHWR.Domain.DTO.Customer;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerModel>> CustomerListAsync(CustomerSearch customerSearch);
        Task<SpResponse> AddCustomer(CustomerDTO customerDTO);
        Task<SpResponse> UpdateCustomerAsync(CustomerUpdateDTO customerUpdateDTO);
        Task<SpResponse> DeleteCustomer(Delete delete);
        Task<IEnumerable<AuditCustomer>> CustomerAuditAsync(SearchAudit searchAudit);
    }
}

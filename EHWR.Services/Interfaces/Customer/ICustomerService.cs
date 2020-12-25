using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Customer;
using EHWR.Domain.DTO.Customer;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerModel>> CustomerListAsync(CustomerSearch customerSearch);
        Task<SpResponse> AddCustomer(CustomerDTO customerDTO);
        Task<SpResponse> UpdateCustomerAnync(CustomerUpdateDTO customerUpdateDTO);
        Task<SpResponse> DeleteCustomer(Delete delete);
        Task<IEnumerable<AuditCustomer>> CustomerAuditAsync(SearchAudit searchAudit);
    }
}

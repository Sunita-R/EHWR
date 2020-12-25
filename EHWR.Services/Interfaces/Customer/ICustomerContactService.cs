using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Customer;
using EHWR.Domain.DTO.Customer;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces.Customer
{
    public interface ICustomerContactService
    {
        Task<IEnumerable<CustomerContactModel>> CustomerContactListAsync(CustomerContactSearch customerContactSearch);
        Task<SpResponse> AddCustomerContantAsync(CustomerContactDTO customerContactDTO);
        Task<SpResponse> UpdateCustomerContantAsync(CustomerContactUpdateDTO customerContactUpdateDTO);
        Task<SpResponse> DeleteCustomerContactAsync(Delete delete);
    }
}

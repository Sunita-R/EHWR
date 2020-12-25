using EHWR.Domain.BusinessRules.Customer;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Customer;
using EHWR.Domain.DTO.Customer;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Customer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Customer
{
    public class CustomerContactService : ICustomerContactService
    {
        private readonly ICustomerContactRepository _customerContactRepository;

        public CustomerContactService(ICustomerContactRepository customerContactRepository)
        {
            _customerContactRepository = customerContactRepository;
        }

        public async Task<SpResponse> AddCustomerContantAsync(CustomerContactDTO customerContactDTO)
        {
            return await _customerContactRepository.AddCustomerContactAsync(customerContactDTO);
        }

        public async Task<IEnumerable<CustomerContactModel>> CustomerContactListAsync(CustomerContactSearch customerContactSearch)
        {
            return await _customerContactRepository.CustomerContactListAsync(customerContactSearch);
        }

        public async Task<SpResponse> DeleteCustomerContactAsync(Delete delete)
        {
            return await _customerContactRepository.DeleteCustomerContactAsync(delete);
        }

        public async Task<SpResponse> UpdateCustomerContantAsync(CustomerContactUpdateDTO customerContactUpdateDTO)
        {
            return await _customerContactRepository.UpdateCustomerContactAsync(customerContactUpdateDTO);
        }
    }
}

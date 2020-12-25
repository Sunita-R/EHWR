using EHWR.Domain.BusinessRules;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Customer;
using EHWR.Domain.DTO.Customer;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<SpResponse> AddCustomer(CustomerDTO customerDTO)
        {
            return await _customerRepository.AddCustomer(customerDTO);
        }

        public async Task<IEnumerable<AuditCustomer>> CustomerAuditAsync(SearchAudit searchAudit)
        {
            return await _customerRepository.CustomerAuditAsync(searchAudit);
        }

        public async Task<IEnumerable<CustomerModel>> CustomerListAsync(CustomerSearch customerSearch)
        {
            return await _customerRepository.CustomerListAsync(customerSearch);
        }

        public async Task<SpResponse> DeleteCustomer(Delete delete)
        {
            return await _customerRepository.DeleteCustomer(delete);
        }

        public async Task<SpResponse> UpdateCustomerAnync(CustomerUpdateDTO customerUpdateDTO)
        {
            return await _customerRepository.UpdateCustomerAsync(customerUpdateDTO);
        }
    }
}

using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Customer;
using EHWR.Domain.DTO.Customer;
using EHWR.Domain.Response;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class CustomerRepository : GenericRepository, ICustomerRepository
    {
        public CustomerRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<SpResponse> AddCustomer(CustomerDTO customerDTO)
        {
            return await CommandAsync<SpResponse>("AddCustomer", customerDTO);
        }

        public async Task<IEnumerable<AuditCustomer>> CustomerAuditAsync(SearchAudit searchAudit)
        {
            return await CollectionsAsync<AuditCustomer>("sp_AuditCustmerEntities", searchAudit);
        }

        public async Task<IEnumerable<CustomerModel>> CustomerListAsync(CustomerSearch customerSearch)
        {
            return await CollectionsAsync<CustomerModel>("GetCustomerList", customerSearch);
        }

        public async Task<SpResponse> DeleteCustomer(Delete delete)
        {
            return await CommandAsync<SpResponse>("DeleteCustomer", delete);
        }

        public async Task<SpResponse> UpdateCustomerAsync(CustomerUpdateDTO customerUpdateDTO)
        {
            return await CommandAsync<SpResponse>("UpdateCustomer", customerUpdateDTO);
        }
    }
}

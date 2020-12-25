using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Customer;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Customer;
using EHWR.Domain.DTO.Customer;
using EHWR.Domain.Response;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Customer
{
    public class CustomerContactRepository : GenericRepository, ICustomerContactRepository
    {
       
        public CustomerContactRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<SpResponse> AddCustomerContactAsync(CustomerContactDTO customerContactDTO)
        {
            return await CommandAsync<SpResponse>("AddCustomerContact", customerContactDTO);
        }

        public async Task<IEnumerable<CustomerContactModel>> CustomerContactListAsync(CustomerContactSearch customerContactSearch)
        {
            return await CollectionsAsync<CustomerContactModel>("GetCustomerContactList", customerContactSearch);
        }

        public async Task<SpResponse> DeleteCustomerContactAsync(Delete delete)
        {
            return await CommandAsync<SpResponse>("DeleteCustomerContacts", delete);
        }

        public async Task<SpResponse> UpdateCustomerContactAsync(CustomerContactUpdateDTO customerContactUpdateDTO)
        {
            return await CommandAsync<SpResponse>("UpdateCustomerContacts", customerContactUpdateDTO);
        }
    }
}

using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Invoice;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Invoice;
using EHWR.Domain.DTO.Invoice;
using EHWR.Domain.DTO.Notes;
using EHWR.Domain.Response;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Invoice
{
    public class CustomerInvoiceRepository: GenericRepository, ICustomerInvoiceRepository
    {
        public CustomerInvoiceRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<SpResponse> AddCustomerInvoice(AddCustomerInvoiceDTO addCustomerInvoiceDTO)
        {
            return await CommandAsync<SpResponse>("sp_AddCustomerInvoice", addCustomerInvoiceDTO);
        }

        public async Task<SpResponse> DeleteCustomerInvoice(Delete delete)
        {
            return await CommandAsync<SpResponse>("sp_DeleteInvoice", delete);
        }

        public async Task<IEnumerable<CustomerInvoiceModel>> CollectionAsync(SearchCustomerInvoice searchCustomerInvoice)
        {
            return await CollectionsAsync<CustomerInvoiceModel>("sp_GetCustomerInvoice", searchCustomerInvoice);
        }

        public async Task<SpResponse> UpdateCustomerInvoiceAsync(UpdateCustomerInvoiceDTO updateCustomerInvoiceDTO)
        {
            return await CommandAsync<SpResponse>("sp_UpdateCustomerInvoice", updateCustomerInvoiceDTO);
        }
    }
}

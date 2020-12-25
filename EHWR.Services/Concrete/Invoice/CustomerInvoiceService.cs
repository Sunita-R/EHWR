using EHWR.Domain.BusinessRules.Invoice;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Invoice;
using EHWR.Domain.DTO.Invoice;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Invoice;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Invoice
{
    public class CustomerInvoiceService : ICustomerInvoiceService
    {
        private readonly ICustomerInvoiceRepository _customerInvoiceRepository;
        public CustomerInvoiceService(ICustomerInvoiceRepository customerInvoiceRepository)
        {
            _customerInvoiceRepository = customerInvoiceRepository;
        }

        public async Task<SpResponse> AddCustomerInvoice(AddCustomerInvoiceDTO addCustomerInvoiceDTO)
        {
            return await _customerInvoiceRepository.AddCustomerInvoice(addCustomerInvoiceDTO);
        }
        public async Task<SpResponse> DeleteCustomerInvoice(Delete delete)
        {
            return await _customerInvoiceRepository.DeleteCustomerInvoice(delete);
        }

        public async Task<IEnumerable<CustomerInvoiceModel>> CollectionAsync(SearchCustomerInvoice searchCustomerInvoice)
        {
            return await _customerInvoiceRepository.CollectionAsync(searchCustomerInvoice);
        }

        public async Task<SpResponse> UpdateCustomerInvoiceAsync(UpdateCustomerInvoiceDTO updateCustomerInvoiceDTO)
        {
            return await _customerInvoiceRepository.UpdateCustomerInvoiceAsync(updateCustomerInvoiceDTO);
        }
    }
}

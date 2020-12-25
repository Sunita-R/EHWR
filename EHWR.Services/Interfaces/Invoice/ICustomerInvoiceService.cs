using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Invoice;
using EHWR.Domain.DTO.Invoice;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces.Invoice
{
    public interface ICustomerInvoiceService
    {
        Task<IEnumerable<CustomerInvoiceModel>> CollectionAsync(SearchCustomerInvoice searchCustomerInvoice);
        Task<SpResponse> AddCustomerInvoice(AddCustomerInvoiceDTO addCustomerInvoiceDTO);
        Task<SpResponse> DeleteCustomerInvoice(Delete delete);
        Task<SpResponse> UpdateCustomerInvoiceAsync(UpdateCustomerInvoiceDTO updateCustomerInvoiceDTO);
    }
}

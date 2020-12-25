using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Invoice;
using EHWR.Domain.DTO.Invoice;
using EHWR.Domain.DTO.Notes;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules.Invoice
{
    public interface ICustomerInvoiceRepository
    {
        Task<IEnumerable<CustomerInvoiceModel>> CollectionAsync(SearchCustomerInvoice searchCustomerInvoice );
        Task<SpResponse> DeleteCustomerInvoice(Delete delete);
        Task<SpResponse> AddCustomerInvoice(AddCustomerInvoiceDTO addCustomerInvoiceDTO);
        Task<SpResponse> UpdateCustomerInvoiceAsync(UpdateCustomerInvoiceDTO updateCustomerInvoiceDTO);
    }
}

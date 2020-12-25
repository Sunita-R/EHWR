using EHWR.Domain.BusinessRules.Invoice;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Invoice;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Invoice;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Invoice
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        public async Task<IEnumerable<InvoiceModel>> CollectionAsync(SearchInvoiceModel searchInvoiceModel)
        {
            return await _invoiceRepository.CollectionAsync(searchInvoiceModel);
        }

        
    }
}

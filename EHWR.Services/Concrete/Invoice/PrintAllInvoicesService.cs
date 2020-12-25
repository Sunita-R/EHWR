using EHWR.Domain.BusinessRules.Invoice;
using EHWR.Services.Interfaces.Invoice;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Invoice
{
    public class PrintAllInvoicesService : IPrintAllInvoicesService
    {
        private readonly IPrintAllInvoicesRepository _printAllInvoicesRepository;

        public PrintAllInvoicesService(IPrintAllInvoicesRepository printAllInvoicesRepository)
        {
            _printAllInvoicesRepository = printAllInvoicesRepository;
        }

        public async Task<IEnumerable<PrintAllInvoices>> PrintInvoiceListAsync(SearchAllInvoicesPrint searchAllInvoicesPrint)
        {
            return await _printAllInvoicesRepository.PrintInvoiceListAsync(searchAllInvoicesPrint);
        }
    }
}

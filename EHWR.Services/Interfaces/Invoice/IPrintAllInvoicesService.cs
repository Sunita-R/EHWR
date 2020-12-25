using EHWR.Services.Concrete.Invoice;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces.Invoice
{
    public interface IPrintAllInvoicesService
    {
        Task<IEnumerable<PrintAllInvoices>> PrintInvoiceListAsync(SearchAllInvoicesPrint searchAllInvoicesPrint);
    }
}

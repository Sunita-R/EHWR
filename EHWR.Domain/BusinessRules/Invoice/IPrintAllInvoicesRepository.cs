using EHWR.Services.Concrete.Invoice;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules.Invoice
{
    public interface IPrintAllInvoicesRepository
    {
        Task<IEnumerable<PrintAllInvoices>> PrintInvoiceListAsync(SearchAllInvoicesPrint searchAllInvoicesPrint);
    }
}

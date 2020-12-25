using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Invoice;
using EHWR.Services.Concrete.Invoice;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Invoice
{
    public class PrintAllInvoicesRepository : GenericRepository, IPrintAllInvoicesRepository
    {
        public PrintAllInvoicesRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<PrintAllInvoices>> PrintInvoiceListAsync(SearchAllInvoicesPrint searchAllInvoicesPrint)
        {
            return await CollectionsAsync<PrintAllInvoices>("sp_GetInvoicestoPrint", searchAllInvoicesPrint);
        }
    }
}

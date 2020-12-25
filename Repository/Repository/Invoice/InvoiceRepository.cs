using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Invoice;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Invoice;
using EHWR.Domain.Response;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Invoice
{
    public class InvoiceRepository : GenericRepository, IInvoiceRepository
    {
        public InvoiceRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<InvoiceModel>> CollectionAsync(SearchInvoiceModel searchInvoiceModel)
        {
            return await CollectionsAsync<InvoiceModel>("sp_GetUnpaidInvoice", searchInvoiceModel);
        }

    }
}

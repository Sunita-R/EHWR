﻿using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Invoice;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces.Invoice
{
    public interface IInvoiceService
    {
        Task<IEnumerable<InvoiceModel>> CollectionAsync(SearchInvoiceModel searchInvoiceModel);

    }
}

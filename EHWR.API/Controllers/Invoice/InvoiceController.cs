using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Invoice;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Invoice;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.Controllers.Invoice
{
    [ApiController]
    [Route("api/[controller]")]

    public class InvoiceController: ControllerBase
    {
        private readonly IInvoiceService _invoiceService;
        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery]SearchInvoiceModel searchInvoiceModel )
        {
            IEnumerable<InvoiceModel> collection = await _invoiceService.CollectionAsync(searchInvoiceModel);
            return Ok(collection);
        }


    }
}

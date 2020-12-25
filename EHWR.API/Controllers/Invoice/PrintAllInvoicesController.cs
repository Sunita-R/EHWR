using EHWR.Services.Concrete.Invoice;
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
    public class PrintAllInvoicesController : ControllerBase
    {
        private readonly IPrintAllInvoicesService _printAllInvoicesService;

        public PrintAllInvoicesController(IPrintAllInvoicesService printAllInvoicesService)
        {
            _printAllInvoicesService = printAllInvoicesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPrintInvoiceAsync([FromQuery] SearchAllInvoicesPrint searchAllInvoicesPrint)
        {
            IEnumerable<PrintAllInvoices> collection = await _printAllInvoicesService.PrintInvoiceListAsync(searchAllInvoicesPrint);
            return Ok(collection);
        }
    }
}

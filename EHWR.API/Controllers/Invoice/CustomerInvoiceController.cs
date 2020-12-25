using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Invoice;
using EHWR.Domain.DTO.Invoice;
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
    public class CustomerInvoiceController : ControllerBase
    {
        private readonly ICustomerInvoiceService _customerInvoiceService;
        public CustomerInvoiceController(ICustomerInvoiceService customerInvoiceService)
        {
            _customerInvoiceService = customerInvoiceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] SearchCustomerInvoice searchCustomerInvoice)
        {
            IEnumerable<CustomerInvoiceModel> collection = await _customerInvoiceService.CollectionAsync(searchCustomerInvoice);
            return Ok(collection);
        }

        [HttpPost]
        public async Task<IActionResult> POST(AddCustomerInvoiceDTO addCustomerInvoiceDTO)
        {
            //JobModel JobScreen = new DTOMapper<JobOrderDTO, AddJobModel>().Serialize(model);
            SpResponse CustomerInvoiceAdded = await _customerInvoiceService.AddCustomerInvoice(addCustomerInvoiceDTO);
            return Ok(CustomerInvoiceAdded);
        }


        [HttpDelete]

        public async Task<IActionResult> Delete([FromQuery] Delete delete)
        {
            SpResponse CustomerInvoiceDeleted = await _customerInvoiceService.DeleteCustomerInvoice(delete);
            return Ok(CustomerInvoiceDeleted);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateCustomerInvoiceDTO updateCustomerInvoiceDTO)
        {
            SpResponse updateCustomerInvoice = await _customerInvoiceService.UpdateCustomerInvoiceAsync(updateCustomerInvoiceDTO);
            return Ok(updateCustomerInvoice);
        }
    }
}

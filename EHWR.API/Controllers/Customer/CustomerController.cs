using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Customer;
using EHWR.Domain.DTO.Customer;
using EHWR.Domain.Response;
using EHWR.Domain.Shared;
using EHWR.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] CustomerSearch customerSearch)
        {
            IEnumerable<CustomerModel> collection = await _customerService.CustomerListAsync(customerSearch);

            return Ok(collection);
        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromQuery] Delete delete)
        {
            SpResponse customerDelete = await _customerService.DeleteCustomer(delete);
            return Ok(customerDelete);
        }

        [HttpPost]

        public async Task<IActionResult> Post(CustomerDTO model)
        {
           SpResponse customerAdd = await _customerService.AddCustomer(model);
           //var StringPath = $"{Directory.GetCurrentDirectory()}{@"/Images/logo-wide.png"}";
            SendNotification.SendEmail(model.Email, "Dear" + "&nbsp;&nbsp; " + "<b>" + model.CustomerName +"</b>"+"<br/><br/>" +"Thanks for Signing up with EHWR"+ "<br/><br/>" + "<b>EHWR Team</b>"+ "<br/><br/>" + "<img src = 'http://ditstekdemo.com/ehwr/images/logo-wide.png' alt = 'Logo' style='width: 30%; height: 15%;'>" , "Welcome to EHWR", true);

            return Ok(customerAdd);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CustomerUpdateDTO model)
        {
            SpResponse customerUpdate = await _customerService.UpdateCustomerAnync(model);
            return Ok(customerUpdate);
        }

        [HttpGet("AuditCustomer")]
        public async Task<IActionResult> GetAsync([FromQuery] SearchAudit searchAudit)
        {
            IEnumerable<AuditCustomer> collection = await _customerService.CustomerAuditAsync(searchAudit);

            return Ok(collection);
        }
    }
}

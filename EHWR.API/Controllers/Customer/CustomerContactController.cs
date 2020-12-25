using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Customer;
using EHWR.Domain.DTO.Customer;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Customer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.Controllers.Customer
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerContactController : ControllerBase
    {
        private readonly ICustomerContactService _customerContactService;
        public CustomerContactController(ICustomerContactService customerContactService)
        {
            _customerContactService = customerContactService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] CustomerContactSearch customerContactSearch)
        {
            IEnumerable<CustomerContactModel> collection = await _customerContactService.CustomerContactListAsync(customerContactSearch);

            return Ok(collection);
        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromQuery] Delete delete)
        {
            SpResponse customerDelete = await _customerContactService.DeleteCustomerContactAsync(delete);
            return Ok(customerDelete);
        }

        [HttpPost]

        public async Task<IActionResult> Post(CustomerContactDTO model)
        {
            SpResponse customerAdd = await _customerContactService.AddCustomerContantAsync(model);
            return Ok(customerAdd);
        }

        [HttpPut]

        public async Task<IActionResult> Put(CustomerContactUpdateDTO model)
        {
            SpResponse customerContactUpdate = await _customerContactService.UpdateCustomerContantAsync(model);
            return Ok(customerContactUpdate);

        }
    }
}

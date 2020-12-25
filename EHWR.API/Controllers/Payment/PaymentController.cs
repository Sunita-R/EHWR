using EHWR.Domain.DomainModel.Payment;
using EHWR.Services.Interfaces.Payment;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.Controllers.Payment
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
       private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] PaymentSearch paymentSearch)
        {
            IEnumerable<PaymentModel> collection = await _paymentService.CollectionAsync(paymentSearch);
            return Ok(collection);
        }
    }
}

using EHWR.Domain.DomainModel.Payment;
using EHWR.Domain.DTO.Payment;
using EHWR.Domain.Response;
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
    public class PaymentOutstandingController : ControllerBase
        {
            private readonly IPaymentOutstandingService _paymentOutstandingService;
            public PaymentOutstandingController(IPaymentOutstandingService paymentOutstandingService)
            {
                _paymentOutstandingService = paymentOutstandingService;
            }

            [HttpGet]
            public async Task<IActionResult> GetAsync([FromQuery] PaymentOutstandingSearch paymentOutstandingSearch)
            {
                IEnumerable<PaymentOutstandingModel> collection = await _paymentOutstandingService.CollectionAsync(paymentOutstandingSearch);
                return Ok(collection);
            }

            [HttpPost]
            // [ProducesResponseType((SpResponse)HttpStatusCode.OK)]
            // [ProducesResponseType((SpResponse)HttpStatusCode.BadRequest)]
            public async Task<IActionResult> POST(PaymentOutstandingDTO paymentOutstandingDTO)
            {
            //JobModel JobScreen = new DTOMapper<JobOrderDTO, AddJobModel>().Serialize(model);
            SpResponse PaymentOutstandingAdded = await _paymentOutstandingService.AddPaymentOutstanding(paymentOutstandingDTO);
            return Ok(PaymentOutstandingAdded);
            }
    }
}

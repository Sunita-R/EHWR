using EHWR.Domain.BusinessRules.Payment;
using EHWR.Domain.DomainModel.Payment;
using EHWR.Domain.DTO.Payment;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Payment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Payment
{
    public class PaymentOutstandingService : IPaymentOutstandingService
    {
        private readonly IPaymentOutstandingRepository _paymentOutstandingRepository;
        public PaymentOutstandingService(IPaymentOutstandingRepository paymentOutstandingRepository)
        {
            _paymentOutstandingRepository = paymentOutstandingRepository;
        }

        public async Task<SpResponse> AddPaymentOutstanding(PaymentOutstandingDTO paymentOutstandingDTO)
        {
            return await _paymentOutstandingRepository.AddPaymentOutstanding(paymentOutstandingDTO);
        }

            public async Task<IEnumerable<PaymentOutstandingModel>> CollectionAsync(PaymentOutstandingSearch paymentOutstandingSearch)
        {
            return await _paymentOutstandingRepository.CollectionAsync(paymentOutstandingSearch);
        }
    }
}

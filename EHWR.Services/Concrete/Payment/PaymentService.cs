using EHWR.Domain.BusinessRules.Payment;
using EHWR.Domain.DomainModel.Payment;
using EHWR.Services.Interfaces.Payment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Payment
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<IEnumerable<PaymentModel>> CollectionAsync(PaymentSearch paymentSearch)
        {
            return await _paymentRepository.CollectionAsync(paymentSearch);
        }
    }
}

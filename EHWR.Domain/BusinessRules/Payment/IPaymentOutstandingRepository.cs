using EHWR.Domain.DomainModel.Payment;
using EHWR.Domain.DTO.Payment;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules.Payment
{
    public interface IPaymentOutstandingRepository
    {
        Task<IEnumerable<PaymentOutstandingModel>> CollectionAsync(PaymentOutstandingSearch paymentOutstandingSearch);

        Task<SpResponse> AddPaymentOutstanding(PaymentOutstandingDTO paymentOutstandingDTO);
    }
}

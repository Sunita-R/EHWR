using EHWR.Domain.DomainModel.Payment;
using EHWR.Domain.DTO.Payment;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces.Payment
{
    public interface IPaymentOutstandingService
    {
        Task<IEnumerable<PaymentOutstandingModel>> CollectionAsync(PaymentOutstandingSearch paymentOutstandingSearch);

        Task<SpResponse> AddPaymentOutstanding(PaymentOutstandingDTO paymentOutstandingDTO);
    }
}

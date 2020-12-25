using EHWR.Domain.DomainModel.Payment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces.Payment
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentModel>> CollectionAsync(PaymentSearch paymentSearch);
    }
}

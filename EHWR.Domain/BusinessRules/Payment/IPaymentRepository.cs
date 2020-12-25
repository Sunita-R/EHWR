using EHWR.Domain.DomainModel.Payment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules.Payment
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<PaymentModel>> CollectionAsync(PaymentSearch paymentSearch);
    }
}

using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Payment;
using EHWR.Domain.DomainModel.Payment;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Payment
{
    public class PaymentRepository : GenericRepository, IPaymentRepository
    {
        public PaymentRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<PaymentModel>> CollectionAsync(PaymentSearch paymentSearch)
        {
            return await CollectionsAsync<PaymentModel>("GetPaymentList", paymentSearch);
        }

    }
}

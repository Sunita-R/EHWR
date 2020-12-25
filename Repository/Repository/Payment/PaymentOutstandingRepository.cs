using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Payment;
using EHWR.Domain.DomainModel.Payment;
using EHWR.Domain.DTO.Payment;
using EHWR.Domain.Response;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Payment
{
    public class PaymentOutstandingRepository : GenericRepository, IPaymentOutstandingRepository
    {
        public PaymentOutstandingRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<SpResponse> AddPaymentOutstanding(PaymentOutstandingDTO paymentOutstandingDTO)
        {
            return await CommandAsync<SpResponse>("AddPaymentOutstanding", paymentOutstandingDTO);
        }

        public async Task<IEnumerable<PaymentOutstandingModel>> CollectionAsync(PaymentOutstandingSearch paymentOutstandingSearch)
        {
            return await CollectionsAsync<PaymentOutstandingModel>("GetPaymentOutstandingList", paymentOutstandingSearch);
        }
    }
}

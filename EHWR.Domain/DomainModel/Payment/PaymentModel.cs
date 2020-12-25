using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Payment
{
    public class PaymentModel
    {
        public int PaymentId { get; set; }

        public DateTime PaymentDate { get; set; }
        public Decimal AmountPayment { get; set; }
    }

    public class PaymentSearch
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
    }
}

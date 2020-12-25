using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Payment
{
    public class PaymentOutstandingDTO
    {
        public int CustomerId { get; set; }
        public int InvoiceId { get; set; }
        public int MethodPayId { get; set; }
        public int MethodRefrenceNumberPayment { get; set; }
        public string InvoiceTo  { get; set; }
        public DateTime PaymentDate { get; set; }
        public Decimal AmountPayment { get; set; }
        public String CreatedBy { get; set; }

    }
}

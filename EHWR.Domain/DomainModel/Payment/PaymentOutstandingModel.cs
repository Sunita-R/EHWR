using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Payment
{
    public class PaymentOutstandingModel
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public int JobOrderId { get; set; }
        public string InvoiceTo { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime SendDate { get; set; }
        public int PageNo { get; set; }
        public string JobAddress { get; set; }
        public decimal AmountInvoice { get; set; }

    }
    public class PaymentOutstandingSearch
    {
        public int jobOrderid { get; set; }
        public int CustomerId { get; set; }
    }
}

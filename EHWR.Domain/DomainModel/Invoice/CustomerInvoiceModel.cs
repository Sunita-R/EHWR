using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Invoice
{
    public class CustomerInvoiceModel
    {
        public int InvoiceId { get; set; }
        public int JobOrderId { get; set; }
        public int CustomerId { get; set; }
        public string InvoiceTo { get; set; }
        public string DueDate { get; set; }
        public string SendDate { get; set; }
        public Decimal AmountInvoice { get; set; }
        public Decimal AmountPaid { get; set; }
        public Decimal AmountDue { get; set; }
        public string Status { get; set; }

    }

    public class SearchCustomerInvoice
    {
        public int JobOrderId { get; set; }
        public int CustomerId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Invoice
{
    public class UpdateCustomerInvoiceDTO
    {
        public int InvoiceId { get; set; }
        public int JobOrderId { get; set; }
        public int Seq { get; set; }
        public int CustomerId { get; set; }
        public string InvoiceTo { get; set; }
        public DateTime DueDate { get; set; }
        public Decimal AmountInvoice { get; set; }
        public Decimal AmountPaid { get; set; }
        public string ModifiedBy { get; set; }

    }
}

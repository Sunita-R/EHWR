using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Invoice
{
    public class AddCustomerInvoiceDTO
    {
        public int JoborderId { get; set; }
        public int Seq { get; set; }
        public int CustomerId { get; set; }
        public string InvoiceTo { get; set; }
        public DateTime DueDate { get; set; }
        public Decimal AmountInvoice { get; set; }
        public string CreatedBy { get; set; }
    }
}

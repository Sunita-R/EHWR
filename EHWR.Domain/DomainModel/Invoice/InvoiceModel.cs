using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Invoice
{
    public class InvoiceModel
    {
        public int JobOrderId { get; set; }
        public int CustomerId { get; set; }
        public string CompletedDate { get; set; }
        public string DueDate { get; set; }
        public int PageNo { get; set; }
        public string JobAddress { get; set; }
        public Decimal Amount { get; set; }
    }

    public class SearchInvoiceModel
    {
        public int JobOrderId { get; set; }
        public int Customerid { get; set; }
    }
}

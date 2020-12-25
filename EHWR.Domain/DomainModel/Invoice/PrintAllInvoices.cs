using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EHWR.Services.Concrete.Invoice
{
    public class PrintAllInvoices
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceTo { get; set; }
        public string JobAddress { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public string JobItemDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal GST { get; set; }
        public decimal TotalAmount { get; set; }        
        public decimal TotalGST { get; set; }      
        public decimal TotalPrice { get; set; }
        public decimal Amount { get; set; }
        public int PageNo { get; set; }
       

    }

    public class SearchAllInvoicesPrint
    {
        public int? CustomerId { get; set; }
        public int? InvoiceId { get; set; }
        public int? AllCustomer { get; set; }
        public DateTime? Dateprinted { get; set; }
        public int? Dayoverdue { get; set; }
        [Required]
        public string Printtype { get; set; }
    }
}

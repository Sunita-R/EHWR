using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Customer
{
    public class AuditCustomer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime LastModifiedByDate { get; set; }
        public string CustomerModule { get; set; }
        public int JobOrderId { get; set; }
        public int InvoiceId { get; set; }
        public int PaymentId { get; set; }
        public int CustomerContactId { get; set; }
    }
    public class SearchAudit
    {
        public int CustomerId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
}

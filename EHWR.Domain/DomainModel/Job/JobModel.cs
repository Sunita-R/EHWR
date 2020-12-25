using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Job
{
    public class JobModel
    {
        public int JobOrderId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int InvoiceId { get; set; }
        public string Employee { get; set; }
        public string OwnerName { get; set; }
        public string JobOrderDescription { get; set; }
        public int PageNo { get; set; }
        public string CompletedDate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public  string  Suburb  {get; set; }
        public string TankDateInstalled { get; set; }
        public string LetterSend { get; set; }
        public bool JobInvoiceStatus { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class JobSearch : Search
    {
        public int JobOrderId { get; set; }

        public int CustomerId { get; set; }
    }
}

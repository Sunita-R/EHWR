using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNo { get; set; }
        public int CustomerTypeId { get; set; }
        public string CustomerType { get; set; }
        public int InvoiceMethodId { get; set; }
        public string InvoiceMethod { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int SuburbId { get; set; }
        public string SuburbName { get; set; }
        public string State { get; set; }
        public int PostCode { get; set; }
        public bool DefaultEmail { get; set; }
        public string Email { get; set; }
        public string Address1Postal { get; set; }
        public string Address2Postal { get; set; }
        public string Address3Postal { get; set; }
        public int SuburbPostalId { get; set; }
        public string SuburbPostalName { get; set; }
        public string StatePostal { get; set; }
        public int PostCodePostal { get; set; }
        public string Suburb { get; set; }
        public string SuburbPostal { get; set; }
        public string CreatedBY { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string TotalRows { get; set; }
    }

    public class CustomerSearch: Search
    {
        public int CustomerId { get; set; }
    }

   
}

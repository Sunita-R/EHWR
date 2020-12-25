using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Customer
{
    public class CustomerUpdateDTO
    {
        public int CustomerId { get; set; }
        public int CustomerTypeId { get; set; }
        public string CustomerName { get; set; }
        public bool DefaultEmail { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int SuburbId { get; set; }
        public string State { get; set; }
        public int PostCode { get; set; }
        public string Address1Postal { get; set; }
        public string Address2Postal { get; set; }
        public string Address3Postal { get; set; }
        public int SuburbPostal { get; set; }
        public string StatePostal { get; set; }
        public int PostCodePostal { get; set; }
        public int InvoiceMethod { get; set; }
        public string ModifiedBy { get; set; }
    }
}

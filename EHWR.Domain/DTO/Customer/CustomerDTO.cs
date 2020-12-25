using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EHWR.Domain.DTO.Customer
{
    public class CustomerDTO
    {
        public int CustomerTypeId { get; set; }
        public string CustomerName { get; set; }
        public bool DefaultEmail { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int SuburbId { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int PostCode { get; set; }
        public string Address1Postal { get; set; }
        public string Address2Postal { get; set; }
        public string Address3Postal { get; set; }
        public int SuburbPostal { get; set; }
        [Required]
        public string StatePostal { get; set; }
        [Required]
        public int PostCodePostal { get; set; }
        public int InvoiceMethod { get; set; }
        public string CreatedBy { get; set; }
    }
}

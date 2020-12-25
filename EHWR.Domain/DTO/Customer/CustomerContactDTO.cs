using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Customer
{
    public class CustomerContactDTO
    {
        public int CustomerId { get; set; }
        public int Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool DefaultEmail { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string PhoneBusiness { get; set; }
        public string CreatedBy { get; set; }

    }
}

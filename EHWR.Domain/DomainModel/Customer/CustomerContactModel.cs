using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Customer
{
    public class CustomerContactModel
    {
        public int CustomerContactId { get; set; }
        public int CustomerId { get; set; }
        public string ContactName { get; set; }
        public string PhoneNo { get; set; }
        public int Salutation { get; set; }
        public string SalutationName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool DefaultEmail { get; set; }
        public string Email { get; set; }
        public string PhoneBusiness { get; set; }
        public string CreatedBY { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
    public class CustomerContactSearch : Search
    {
        public int CustomerContactId { get; set; }
        public int CustomerId { get; set; }
    }
}

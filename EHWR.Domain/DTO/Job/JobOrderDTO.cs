using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.DTO.Job
{
    public class UpdateJobDTO 
    {
        public int JobOrderId { get; set; }
        public int CustomerId { get; set; }
        public int StatusId { get; set; }
        public int EmployeeId { get; set; }
        public string OwnerName { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string JobOrderDescription { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int Suburb { get; set; }
        public string State { get; set; }
        public int PostCode { get; set; }
        public int PageNo { get; set; }
        public string Position { get; set; }
        public DateTime? TankDateInstalled { get; set; }
        public DateTime? LetterSend { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class AddJobOrderDTO
    {
        public int CustomerId { get; set; }
        public int StatusId { get; set; }
        public int EmployeeId { get; set; }
        public string OwnerName { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string JobOrderDescription { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int Suburb { get; set; }
        public string State { get; set; }
        public int PostCode { get; set; }
        public int PageNo { get; set; }
        public string Position { get; set; }
        public DateTime? TankDateInstalled { get; set; }
        public DateTime? LetterSend { get; set; }
        public string CreatedBy { get; set; }
    }

    
}

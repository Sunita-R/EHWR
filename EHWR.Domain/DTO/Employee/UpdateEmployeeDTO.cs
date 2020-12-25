using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Employee
{
    public class UpdateEmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string ModifiedBy { get; set; }
    }
}

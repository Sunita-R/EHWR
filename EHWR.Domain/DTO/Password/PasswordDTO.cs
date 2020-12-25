using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Password
{
    public class UpdatePasswordDTO
    {
        public string NormalizedUserName { get; set; }
        public string NormalizedEmail { get; set; }
        public string Passwordhash { get; set; }
        public string ModifiedBy { get; set; }
    }
}

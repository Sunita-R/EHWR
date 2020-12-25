using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Account
{
    public class AccountLogModel
    {
        public string UserId { get; set; }
        public DateTime LoginDateTime { get; set; }
        public bool Success { get; set; }
    }

    public class AccountLogOutModel
    {
        public string UserId { get; set; }
        public DateTime LogOutDateTime { get; set; }
        public bool Success { get; set; }
    }
}

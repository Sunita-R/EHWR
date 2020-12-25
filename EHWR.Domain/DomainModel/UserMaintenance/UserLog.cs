using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.UserMaintenance
{
   public class UserLog
    {
        public int UserLoginAuditLogId { get; set; }

        public string UserName { get; set; }

        public DateTime LoginDateTime { get; set; }

        public DateTime LogOutDateTime { get; set; }

        public int TotalRows { get; set; }
    }
}

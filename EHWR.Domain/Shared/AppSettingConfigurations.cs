using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.Shared
{
    public class AppSettingConfigurations
    {
        public static AppSettings AppSettings { get; set; }
    }


    public class AppSettings
    {
        public string SmtpServer { get; set; }
        public string SmtpPort { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpSslEnabled { get; set; }
    }
}

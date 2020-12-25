using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace EHWR.Domain.Shared
{
    public class SendNotification
    {
        public static void SendEmail(string emailAddress, String bodyMessage, string subject, bool html)
        {
            try
            {
                MailMessage email = new MailMessage();
                email.From = new MailAddress(AppSettingConfigurations.AppSettings.SmtpUser);
                email.To.Add(new MailAddress(emailAddress));
                email.Subject = subject;
                email.Body = bodyMessage;
                email.IsBodyHtml = html;

                SmtpClient smtpServer = new SmtpClient();
                smtpServer.Host = AppSettingConfigurations.AppSettings.SmtpServer;
                smtpServer.Port = Convert.ToInt32(AppSettingConfigurations.AppSettings.SmtpPort);
                smtpServer.Credentials = new NetworkCredential(AppSettingConfigurations.AppSettings.SmtpUser, AppSettingConfigurations.AppSettings.SmtpPassword);
                smtpServer.EnableSsl = Convert.ToBoolean(AppSettingConfigurations.AppSettings.SmtpSslEnabled);
                smtpServer.Send(email);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }  
    }
}

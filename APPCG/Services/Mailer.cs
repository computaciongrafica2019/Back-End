using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Services
{
    public class Mailer
    {
        private String mailBody;
        private String eErom;
        private String eTo;
        private String subject;
        private String user;
        private String password;
        private String attachmentRoute;

        public string MailBody { get; set; }
        public string EFrom { get; set; }
        public string ETo { get; set; }
        public string Subject { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string AttachmentRoute { get; set; }

        public Mailer(string mailBody, string eFrom, string eTo, string subject, string user, string password, string attachmentRoute)
        {
            MailBody = mailBody;
            EFrom = eErom;
            ETo = eTo;
            Subject = subject;
            User = user;
            Password = password;
            AttachmentRoute = attachmentRoute;

        }

        public String createAndSendMail()
        {
            var client = new SmtpClient();
            var mail = new MimeMessage();
            var mailBody = new BodyBuilder();

            mail.From.Add(new MailboxAddress(this.EFrom));
            mail.To.Add(new MailboxAddress(this.ETo));
            mail.Subject = this.subject;

            mailBody.TextBody = this.MailBody;
            mailBody.Attachments.Add(this.AttachmentRoute);
            mail.Body = mailBody.ToMessageBody();

            try
            {
                client.Connect("smtp.office365.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                client.Authenticate(this.user, this.password);
                client.Send(mail);
                client.Disconnect(true);
                return "Mensaje Creado";
                
            }
            catch (Exception ex)
            {
                return "Error :" + ex.ToString();
            }

        }


    }

}
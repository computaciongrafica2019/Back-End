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

        public string MailBody { get; set; }
        public string EFrom { get; set; }
        public string ETo { get; set; }
        public string Subject { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public String[] AttachmentRoute { get; set; }

        public Mailer(string mailBody, string eTo, string subject, String[] attachmentRoute)
        {

            MailBody = mailBody;
            EFrom = "cg2019i@outlook.com";
            ETo = eTo;
            Subject = subject;
            User = "cg2019i@outlook.com";
            Password = "Cg123456789";
            AttachmentRoute = attachmentRoute;

        }

        public String createAndSendMail()
        {
            var client = new SmtpClient();
            var mail = new MimeMessage();
            var mailBody = new BodyBuilder();

            mail.From.Add(new MailboxAddress(this.EFrom));
            mail.To.Add(new MailboxAddress(this.ETo));
            mail.Subject = this.Subject;

            mailBody.TextBody = this.MailBody;
            
            mailBody.Attachments.Add(this.AttachmentRoute[0]);
            mailBody.Attachments.Add(this.AttachmentRoute[1]);


            mail.Body = mailBody.ToMessageBody();

            try
            {
                client.Connect("smtp.office365.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                client.Authenticate(this.User, this.Password);
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
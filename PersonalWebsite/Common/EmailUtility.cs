using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PersonalWebsite.Common
{
    public class EmailUtility
    {
        public async Task SendEmailAsync(string to, String subject, String body)
        {
            SmtpClient client = new SmtpClient("mail.chelipaco.ir");
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("no-reply@chelipaco.ir", "Pvm55NkXGVAK6qR");

            MailMessage mailMessage = new MailMessage();
            mailMessage.IsBodyHtml = true;
            mailMessage.From = new MailAddress("no-reply@chelipaco.ir");
            mailMessage.To.Add(to);
            mailMessage.Body = body;
            mailMessage.Subject = subject;

            await client.SendMailAsync(mailMessage);
        }
    }
}

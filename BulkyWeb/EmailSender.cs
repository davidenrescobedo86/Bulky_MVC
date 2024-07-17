using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace BulkyWeb
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //logic to send email
            var mail = "davidenrescobedo86@yahoo.com";
            var pw = "ujvyiiauzptsotip";

            var client = new SmtpClient("smtp.mail.yahoo.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)
            };

            return client.SendMailAsync(
                new MailMessage(mail, email, subject, htmlMessage)
                );
        }
    }
}

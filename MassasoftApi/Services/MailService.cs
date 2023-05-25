using MailKit.Net.Smtp;
using MailKit.Security;
using DevOpsExamApi.Model;
using Microsoft.Extensions.Options;
using MimeKit;

namespace DevOpsExamApi.Services
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        private string toEmail = "testingstuffeasv@gmail.com";

        public MailService()
        {
            _mailSettings = new MailSettings();
        }

        public async Task SendEmailAsync(Message mailRequest)
        {
            //build mail parameter
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(mailRequest.Email);
            email.To.Add(MailboxAddress.Parse(toEmail));
            email.Subject = mailRequest.Subject;

            //build body
            var builder = new BodyBuilder();
            builder.HtmlBody = mailRequest.Body;
            email.Body = builder.ToMessageBody();

            //send mail
            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}

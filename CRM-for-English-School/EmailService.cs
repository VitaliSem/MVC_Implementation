using CRM_for_English_School.Configuration;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Threading.Tasks;

namespace CRM_for_English_School
{
    public class EmailService
    {
        private readonly string _emailSender;
        private readonly string _emailSenderPassword;
        private readonly string _emailReceiver;

        public EmailService(IOptions<EmailSenderOptions> emailSenderOptions, IOptions<EmailTestReveiverOptions> emailReceiverOptions)
        {
            _emailSender = emailSenderOptions.Value.Email;
            _emailSenderPassword = emailSenderOptions.Value.Password;
            _emailReceiver = emailReceiverOptions.Value.Email;
        }

        public async Task SendEmailAsync(string email , string subject, string message)
        {
            email ??= _emailReceiver;
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("English School", _emailSender));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new BodyBuilder()
            {
                HtmlBody = message
            }.ToMessageBody();
            using MailKit.Net.Smtp.SmtpClient client = new();
            await client.ConnectAsync("smtp.mail.ru", 2525, false);
            await client.AuthenticateAsync(_emailSender, _emailSenderPassword);
            await client.SendAsync(emailMessage);
            await client.DisconnectAsync(true);
        }
    }
}

using My_App.Application.Core.Abstractions.Emails;
using System.Net;
using System.Net.Mail;

namespace My_App.Infrastructure.Emails;

internal class EmailService : IEmailService
{
    private readonly SmtpClient _smtpClient;
    private readonly string _from;

    public EmailService(string host, int port, string from, string username, string password)
    {
        _from = from;
        _smtpClient = new SmtpClient(host, port)
        {
            Credentials = new NetworkCredential(username, password),
            EnableSsl = true
        };
    }

    public async Task SendEmailAsync(string to, string subject, string body)
    {
        var mailMessage = new MailMessage(_from, to, subject, body)
        {
            IsBodyHtml = true
        };

        await _smtpClient.SendMailAsync(mailMessage);
    }
}

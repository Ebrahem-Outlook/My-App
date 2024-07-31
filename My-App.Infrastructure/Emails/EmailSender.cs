using My_App.Application.Core.Abstractions.Emails;

namespace My_App.Infrastructure.Emails;

internal class EmailSender : IEmailService
{
    public Task SendEmail(string to, string from, string message)
    {
        throw new NotImplementedException();
    }
}

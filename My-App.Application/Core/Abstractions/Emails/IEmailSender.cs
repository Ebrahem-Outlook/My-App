namespace My_App.Application.Core.Abstractions.Emails;

public interface IEmailService
{
    Task SendEmail(string to, string from, string message);
}

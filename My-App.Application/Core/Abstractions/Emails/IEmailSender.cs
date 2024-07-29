namespace My_App.Application.Core.Abstractions.Emails;

public interface IEmailSender
{
    void SendEmail(string email);
}

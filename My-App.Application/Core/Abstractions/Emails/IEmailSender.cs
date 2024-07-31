using System.Threading.Tasks;

namespace My_App.Application.Core.Abstractions.Emails;

public interface IEmailService
{
    Task SendEmailAsync(string to, string subject, string body);
}

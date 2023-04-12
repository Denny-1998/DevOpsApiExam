using MassasoftApi.Model;

namespace MassasoftApi.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(Message mailRequest);
    }
}

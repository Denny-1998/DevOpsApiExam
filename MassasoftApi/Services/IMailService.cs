using DevOpsExamApi.Model;

namespace DevOpsExamApi.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(Message mailRequest);
    }
}

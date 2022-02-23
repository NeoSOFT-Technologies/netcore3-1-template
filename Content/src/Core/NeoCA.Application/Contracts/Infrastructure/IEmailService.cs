using NeoCA.Application.Models.Mail;
using System.Threading.Tasks;

namespace NeoCA.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}

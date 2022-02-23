using NeoCA.Domain.Entities;
using System.Threading.Tasks;

namespace NeoCA.Application.Contracts.Persistence
{
    public interface IMessageRepository : IAsyncRepository<Message>
    {
        public Task<Message> GetMessage(string Code, string Lang);
    }
}

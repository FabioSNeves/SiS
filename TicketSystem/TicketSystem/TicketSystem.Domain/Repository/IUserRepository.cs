using TicketSystem.Domain.Users;

namespace TicketSystem.Domain.Repository
{
    public interface IUserRepository
    {
        User Get(string username, string password);
    }
}

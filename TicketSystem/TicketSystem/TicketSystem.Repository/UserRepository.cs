using Calmo.Data.SQLServer;
using TicketSystem.Domain.Repository;
using TicketSystem.Domain.Users;
using TicketSystem.Repository.DTO;

namespace TicketSystem.Repository
{
    public class UserRepository : Calmo.Data.Repository, IUserRepository
    {
        public User Get(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var parameters = new
            {
                username,
                password
            };

            var user = this.Data.Db()
                .WithParameters(parameters)
                .Get<UserAuthDTO>("GetUser");

            return user.ToDomain();
        }
    }
}

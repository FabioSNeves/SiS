using TicketSystem.Domain.Users;

namespace TicketSystem.Repository.DTO
{
    public class UserAuthDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public UserType Type { get; set; }

        public User ToDomain()
        {
            return new User
            {
                Id = this.Id,
                Name = this.Name,
                Type = this.Type
            };
        }
    }
}


namespace TicketSystem.Domain.Users
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public UserType Type { get; set; }
    }
}

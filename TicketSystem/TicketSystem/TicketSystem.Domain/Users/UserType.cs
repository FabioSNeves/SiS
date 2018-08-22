using System.ComponentModel;

namespace TicketSystem.Domain.Users
{
    public enum UserType
    {
        [Description("Funcionário")]
        Employee = 1,

        [Description("Atendente")]
        Assistant = 2
    }
}

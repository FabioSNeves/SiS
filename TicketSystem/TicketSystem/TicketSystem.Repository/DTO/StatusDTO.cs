using TicketSystem.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TicketSystem.Repository.DTO
{

    public class StatusDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Status ToDomain()
        {
            return new Status
            {
                StatusId = this.Id,
                StatusDescription = this.Description
            };
        }
    }

    public static class StatusDTOExtensions
    {
        public static IEnumerable<Status> ToDomain(this IEnumerable<StatusDTO> dtos)
        {
            return dtos.Select(d => d.ToDomain());
        }
    }
}

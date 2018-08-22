using System.Collections.Generic;
using System.Linq;
using TicketSystem.Domain;

namespace TicketSystem.Api.Models
{
    public class StatusModel
    {
        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
    }

    public static class StatusModelExtensions
    {
        public static StatusModel ToModel(this Status domain)
        {
            return new StatusModel
            {
                StatusId = domain.StatusId,
                StatusDescription = domain.StatusDescription
            };
        }

        public static IEnumerable<StatusModel> ToModel(this IEnumerable<Status> statuses)
        {
            return statuses.Select(status => status.ToModel()).ToList();
        }
    }
  
}



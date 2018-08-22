using System;
using System.Collections.Generic;
using System.Linq;
using TicketSystem.Domain;


namespace TicketSystem.Repository.DTO
{
    public class IncidentDTO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOpen { get; set; }
        public string Description { get; set; }
        public string Response { get; set; }
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
        public long User_Id { get; set;  }
        public string Name { get; set; }

        public Incident ToDomain()
        {
            return new Incident
            {
                Id = this.Id,
                Title = this.Title,
                DateOpen = this.DateOpen,
                Description = this.Description,
                Response = this.Response,
                User_Id = this.User_Id,
                Name = this.Name,
                StatusId = this.StatusId,
                StatusDescription = this.StatusDescription,
                CategoryId = this.CategoryId,
                CategoryDescription = this.CategoryDescription
            };
        }
    }
            
        public static class IncidentDTOExtensions
        {
            public static IEnumerable<Incident> ToDomain(this IEnumerable<IncidentDTO> dtos)
            {
                return dtos.Select(d => d.ToDomain());
            }
        }    
}



    


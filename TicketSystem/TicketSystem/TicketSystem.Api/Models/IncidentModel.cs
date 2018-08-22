using System;
using System.Collections.Generic;
using System.Linq;
using TicketSystem.Domain;


namespace TicketSystem.Api.Models
{
    public class IncidentModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOpen { get; set; }
        public string Description { get; set; }
        public string Response { get; set; }
        public long User_Id { get; set;}
        public string Name { get; set; }
        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }

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

    public static class IncidentModelExtensions
    {
        public static IncidentModel ToModel(this Incident domain)
        {
            return new IncidentModel
            {
                Id = domain.Id,
                Title = domain.Title,
                DateOpen = domain.DateOpen,
                Description = domain.Description,
                Response = domain.Response,
                User_Id = domain.User_Id,
                Name = domain.Name,
                CategoryId = domain.CategoryId,
                StatusDescription = domain.StatusDescription,
                StatusId = domain.StatusId,
                CategoryDescription = domain.CategoryDescription

            };
        }

        public static IEnumerable<IncidentModel> ToModel(this IEnumerable<Incident> incidents)
        {
            return incidents.Select(incident => incident.ToModel()).ToList();
        }
    }
}
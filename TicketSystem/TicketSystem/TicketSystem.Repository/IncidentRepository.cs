using System.Collections.Generic;
using Calmo.Data.SQLServer;
using TicketSystem.Domain;
using TicketSystem.Domain.Repository;
using TicketSystem.Repository.DTO;

namespace TicketSystem.Repository
{
    public class IncidentRepository : Calmo.Data.Repository, IIncidentRepository
    {
        public Incident GetId(long id)
        {
            var result = this.Data.Db()
                                  .AsProcedure()
                                  .WithParameters(new { id })
                                  .Get<IncidentDTO>("FABIO_getIncidentsById");

            return result.ToDomain();
        }


        public IEnumerable<Incident> ListStatus(int StatusId)
        {
            var result = this.Data.Db()
                             .AsProcedure()
                             .WithParameters(new { StatusId })
                             .List<IncidentDTO>("FABIO_listIncidentsByStatus");

            return result.ToDomain();
        }

        public IEnumerable<Incident> List()
        {
            var result = this.Data.Db()
                             .AsProcedure()
                             .List<IncidentDTO>("FABIO_listIncidents");

            return result.ToDomain();
        }

        public IEnumerable<Incident> ListCategory(int CategoryId)
        {
            var result = this.Data.Db()
                             .AsProcedure()
                             .List<IncidentDTO>("FABIO_listIncidentsByCategory");

            return result.ToDomain();
        }
        
       public long Add(Incident incident)
        {
            var parameters = new
            {
                title = incident.Title,
                dateOpen = incident.DateOpen,              
                description = incident.Description,
                response = incident.Response,
                user_Id = incident.User_Id,
                name = incident.Name,
                categoryId = incident.CategoryId,
                categoryDescription = incident.CategoryDescription,
                statusId = incident.StatusId,
                statusDescription = incident.StatusDescription
            };

            return this.Data.Db()
                .WithParameters(parameters)
                .Execute<long>("FABIO_insertIncident");
        }

        public void Update(Incident incident)
        {
            var parameters = new
            {
                id = incident.Id,
                response = incident.Response,
                statusId = incident.StatusId              
            };

            this.Data.Db().WithParameters(parameters).Execute("FABIO_updateIncident");
        }
    }
}


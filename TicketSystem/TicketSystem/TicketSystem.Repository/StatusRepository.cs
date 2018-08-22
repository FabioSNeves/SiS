using System.Collections.Generic;
using Calmo.Data.SQLServer;
using TicketSystem.Repository.DTO;
using TicketSystem.Domain;
using TicketSystem.Domain.Repository;


namespace TicketSystem.Repository
{
    public class StatusRepository : Calmo.Data.Repository, IStatusRepository
    {
        public IEnumerable<Status> ListStatus()
        {
            var result = this.Data.Db().AsProcedure().List<StatusDTO>("FABIO_listStatuses");
            return result.ToDomain();
        }
    }
}

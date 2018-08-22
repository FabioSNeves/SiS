using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Domain;
using TicketSystem.Domain.Repository;

namespace TicketSystem.Domain.Repository
{
    public interface IIncidentRepository
    {
        Incident GetId(long id);
        IEnumerable<Incident> List();
        long Add(Incident incident);
        void Update(Incident incident);
    }
}


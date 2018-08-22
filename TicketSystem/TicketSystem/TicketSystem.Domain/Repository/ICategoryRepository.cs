using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.Domain.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> List();
    }
}

using System.Collections.Generic;
using Calmo.Data.SQLServer;
using TicketSystem.Repository.DTO;
using TicketSystem.Domain;
using TicketSystem.Domain.Repository;


namespace TicketSystem.Repository
{
    public class CategoryRepository : Calmo.Data.Repository, ICategoryRepository
    {
        public IEnumerable<Category> List()
        {
            var result = this.Data.Db().AsProcedure().List<CategoryDTO>("FABIO_listIncidentsByCategory");
            return result.ToDomain();
        }
    }
}

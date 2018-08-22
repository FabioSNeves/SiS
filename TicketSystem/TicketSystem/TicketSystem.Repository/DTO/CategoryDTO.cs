using TicketSystem.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TicketSystem.Repository.DTO
{

    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Category ToDomain()
        {
            return new Category
            {
                CategoryId = this.Id,
                CategoryDescription = this.Description
            };
        }
    }

    public static class CategoryDTOExtensions
    {
        public static IEnumerable<Category> ToDomain(this IEnumerable<CategoryDTO> dtos)
        {
            return dtos.Select(d => d.ToDomain());
        }
    }
}

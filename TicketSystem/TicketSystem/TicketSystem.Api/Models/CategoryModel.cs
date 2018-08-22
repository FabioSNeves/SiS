using System.Collections.Generic;
using System.Linq;
using TicketSystem.Domain;

namespace TicketSystem.Api.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }
    }

    public static class CategoryModelExtensions
    {
        public static CategoryModel ToModel(this Category domain)
        {
            return new CategoryModel
            {
                CategoryId = domain.CategoryId,
                CategoryDescription = domain.CategoryDescription
            };
        }

        public static IEnumerable<CategoryModel> ToModel(this IEnumerable<Category> categories)
        {
            return categories.Select(category => category.ToModel()).ToList();
        }
    }

}



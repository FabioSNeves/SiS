using System.Net;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using TicketSystem.Api.Models;
using TicketSystem.Repository;


namespace TicketSystem.Api.Controllers
{
    [RoutePrefix("api/incidents")]
    public class CategoryController : BaseController
    {
        // GET api/status
        /// <summary>Authenticate an incident.</summary>
        /// <param ></param>
        /// <returns> A json object containing the authenticated user info.</returns>
        [HttpGet]
        [Route("list-category")]
        [SwaggerResponse(HttpStatusCode.OK, "Sucess", typeof(CategoryModel))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Category not exist")]
        public IHttpActionResult List()
        {
            var repository = new CategoryRepository();
            var categories = repository.List();
            var models = categories.ToModel();

            return Ok(models);
        }

    }
}


using System.Web.Http;
using TicketSystem.Domain;
using Swashbuckle.Swagger.Annotations;
using TicketSystem.Api.Models;
using TicketSystem.Repository;
using System.Net;

namespace TicketSystem.Api.Controllers
{
    [RoutePrefix("status")]
    public class StatusController : BaseController
    {
        /// <summary>Authenticate an incident.</summary>
        /// <param></param>
        /// <returns> A json object containing the authenticated user info.</returns>
        [HttpGet]
        [Route("list-status")]
        [SwaggerResponse(HttpStatusCode.OK, "Sucess")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Status not exist")]
        public IHttpActionResult ListStatus()
        {
            var repository = new StatusRepository();
            var statuses = repository.ListStatus();
            
            return Ok(statuses.ToModel());
        }

    }
}


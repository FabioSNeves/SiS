using System.Net;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using TicketSystem.Api.Models;
using TicketSystem.Repository;
using System;


namespace TicketSystem.Api.Controllers
{
    [RoutePrefix("api/incidents")]
    public class IncidentController : BaseController
    {
        /// <summary>Authenticate an user.</summary>
        /// <param ></param>
        /// <returns> A json object containing the authenticated user info.</returns>
        [HttpGet]
        [Route("list-incidents")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Incidents not found")]
        public IHttpActionResult List()
        {
            var repository = new IncidentRepository();
            var incidents = repository.List();
         
            return this.Ok(incidents.ToModel());
        }

        [HttpPost]
        [Route("add-incident")]
        [SwaggerResponse(HttpStatusCode.Unauthorized, "")]
        public IHttpActionResult Add(IncidentModel model)
        {
            try
            {
                var incident = model.ToDomain();
                incident.Repository = new IncidentRepository();
                incident.Save();

                return Content(HttpStatusCode.NoContent, string.Empty);

            }
            catch (DomainException exception)
            {
                return this.BadRequest(string.Join(",", exception.Errors));
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPost]
        [Route("update-incident")]
        public IHttpActionResult Update(IncidentModel model)
        {
            try
            {
                var incident = model.ToDomain();
                incident.Repository = new IncidentRepository();
                incident.Update();

                return Content(HttpStatusCode.NoContent, string.Empty);
            }
            catch (ArgumentNullException)
            {
                return InternalServerError();
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet]
        [Route("list-incident-id")]
        [SwaggerResponse(HttpStatusCode.OK, "Sucess", typeof(IncidentModel))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Category does not exist")]
        public IHttpActionResult ListId(long Id)
        {
            try
            {
                var repository = new IncidentRepository();
                var incident = repository.GetId(Id);
                var model = incident.ToModel();

                return this.Ok(model);
                
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
    }
}








using System.Net;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using TicketSystem.Api.Models;
using TicketSystem.Domain.Users;
using TicketSystem.Repository;

namespace TicketSystem.Api.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : BaseController
    {
        /// <summary>Authenticate an user.</summary>
        /// <param name="auth"></param>
        /// <returns> A json object containing the authenticated user info.</returns>
        [HttpPost]
        [Route("auth")]
        [SwaggerResponse(HttpStatusCode.OK, "Authenticated", typeof(UserModel))]
        [SwaggerResponse(HttpStatusCode.Unauthorized, "Wrong username or password.")]
        public IHttpActionResult Authorize([FromBody]AuthModel auth)
        {
            var repository = new UserRepository();
            var user = repository.Get(auth.Username, auth.Password);

            if (user == null)
                return Unauthorized();

            return this.Ok(user.ToModel());
        }

    }
}

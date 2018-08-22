using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;

namespace TicketSystem.Api.Controllers
{
    /// <inheritdoc />
    public class BaseController : ApiController
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public ResponseMessageResult NoContent()
        {
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.NoContent));
        }
    }
}
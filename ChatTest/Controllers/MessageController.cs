using ChatTest.Models.DAO;
using System;
using System.Web.Http;

namespace ChatTest.Controllers
{
    [RoutePrefix("Message")]
    public class MessageController : ApiController
    {
        [HttpPost]
        [Route("Response")]
        public IHttpActionResult Response()
        {
            try
            {
                var response = new PersonDAO().getResponse();

                return Ok(response);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}

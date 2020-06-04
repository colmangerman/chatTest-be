using ChatTest.Models.DAO;
using ChatTest.Services;
using System;
using System.Web.Http;

namespace ChatTest.Controllers
{
    [RoutePrefix("Message")]
    public class MessageController : ApiController
    {
        MessageService messageService = new MessageService();

        [HttpPost]
        [Route("Response")]
        public IHttpActionResult Response()
        {
            try
            {
                var response = messageService.getResponse();

                return Ok(response);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}

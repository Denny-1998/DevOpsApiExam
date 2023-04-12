using MassasoftApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace MassasoftApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AboutController : ControllerBase
    {

        [HttpPost(Name = "send message")]
        public async Task<ActionResult> SendMessage(MessageDTO request)
        {
            Message message = new Message(request.Sender, request.Subject, request.Message);

            return Ok("email sent.");
        }

    }
}
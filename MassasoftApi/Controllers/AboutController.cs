using MassasoftApi.Model;
using Microsoft.AspNetCore.Mvc;
using MassasoftApi.Services;

namespace MassasoftApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AboutController : ControllerBase
    {

        private readonly IMailService mailService;
        public AboutController()
        {
            this.mailService = new MailService();
        }




        [HttpPost(Name = "send message")]
        public async Task<ActionResult> SendMessage(MessageDTO request)
        {
            Message message = new Message(request.Sender, request.Subject, request.Message);



            try
            {
                await mailService.SendEmailAsync(message);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
using DevOpsExamApi.Model;
using Microsoft.AspNetCore.Mvc;
using DevOpsExamApi.Services;
using DevOpsApi.Services;

namespace DevOpsExamApi.Controllers
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

        [HttpGet]
        public async Task<ActionResult> DebugConnectionString()
        {
            FileReader fr = new FileReader();
            string sof = fr.getConnectionString();
            return Ok(sof);
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
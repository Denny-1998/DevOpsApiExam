using DevOpsExamApi.Model;
using Microsoft.AspNetCore.Mvc;
using DevOpsExamApi.Services;
using DevOpsApi.Services;
using DevOpsApi.Model;

namespace DevOpsExamApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AboutController : ControllerBase
    {

        private readonly IMailService mailService;
        private readonly DBcontext dBcontext;
        public AboutController(DBcontext dBcontext)
        {
            this.mailService = new MailService();
            this.dBcontext = dBcontext;
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
            //get message from json
            Message message = new Message(request.Sender, request.Subject, request.Message);

            try
            {
                //send message to database
                dBcontext.insertMessage(message);

                //send message to email
                await mailService.SendEmailAsync(message);

                //return 200
                return Ok();
            }
            catch (Exception ex)
            {
                //return 400 with error message
                return BadRequest(ex.Message);
            }


        }
    }
}
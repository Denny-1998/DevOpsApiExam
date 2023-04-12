using MassasoftApi.Model;

namespace MassasoftApi.BusinessLogic
{
    public class EmailSender
    {
        string reciever;
        public EmailSender(string reciever) 
        {
            this.reciever = reciever;
        }

        public void send (Message message)
        {
            //TODO send email with message
        }
    }
}

namespace DevOpsExamApi.Model
{
    public class Message
    {

        public string Email;
        public string Subject;
        public string Body;
        public Message(string Email, string Subject, string Body) 
        {
            this.Email = Email;
            this.Subject = Subject;
            this.Body = Body;
        }
    }
}

using System.Net;
using MassasoftApi.Controllers;
using MassasoftApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace MassasoftApiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            string testEmail = "test@example.com";
            string testSubject = "test";
            string testMessage = "this is a test message.";

            MessageDTO mDTO = new MessageDTO();
            mDTO.Sender = testEmail;
            mDTO.Subject = testSubject;
            mDTO.Message = testMessage;


            AboutController wfc = new AboutController();
            ActionResult statuscode = await wfc.SendMessage(mDTO);
            string actual = statuscode.ToString();
            string expected = "Microsoft.AspNetCore.Mvc.OkObjectResult";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void PrintTest() 
        {
            string test = "-----------------Testing--------------------";
            Console.WriteLine(test);

            bool actual = true;

            Assert.IsTrue(actual);
        }
    }
}
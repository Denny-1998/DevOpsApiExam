using System.Net;
using MassasoftApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MassasoftApiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            WeatherForecastController wfc = new WeatherForecastController();
            ActionResult statuscode = await wfc.Get();
            string actual = statuscode.ToString();
            string expected = "Microsoft.AspNetCore.Mvc.OkObjectResult";

            Assert.AreEqual(expected, actual);

        }
    }
}
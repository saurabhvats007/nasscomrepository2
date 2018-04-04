using System.Web.Http;

namespace DummyWebApi.Controller
{
    public class EmployeeController:ApiController
    {

        public IHttpActionResult Get()
        {
            return Ok(new { FirstName = "Saurabh", LastName = "Vats" });
        }
    }
}

using BuildIndia.ViewModel;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DummyWebApi.Controller
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class VehicleController:ApiController
    {

        public IHttpActionResult Get()
        {
            return Ok(new List<VehicleViewModel>{ new VehicleViewModel { VehicleDetails = "new Tata Truck", VehicleNumber = "UK07 AM 5423",RegistrationYear="2017",ServiceProvider="Chanson" } ,
                                                  new VehicleViewModel { VehicleDetails = "new Escorts Truck", VehicleNumber = "UP13 AD 1111",RegistrationYear="2017",ServiceProvider="Chanson" }
            });
        }
    }
}

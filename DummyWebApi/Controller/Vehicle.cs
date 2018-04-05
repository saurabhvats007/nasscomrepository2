using BuildIndia.Service.Repository;
using BuildIndia.ViewModel;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DummyWebApi.Controller
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class VehicleController : ApiController
    {
        private VehicleRepository _vehicleRepo;

        public VehicleController()
        {
            _vehicleRepo = new VehicleRepository();
        }
        public IHttpActionResult Get()
        {
            return Ok(_vehicleRepo.GetAllVehicles());

        }
    }
}
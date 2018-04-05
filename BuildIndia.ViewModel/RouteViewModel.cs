using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildIndia.ViewModel
{
    public class RouteViewModel
    {
        public int Id { get; set; }
        public string RouteNumber { get; set; }
        public string VehicleNo { get; set; }
        public Nullable<int> DriverID { get; set; }
        public Nullable<int> CrewID { get; set; }
        public Nullable<int> WorkerID { get; set; }
        public string Location { get; set; }
    }
}

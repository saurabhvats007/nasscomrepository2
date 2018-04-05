using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildIndia.ViewModel
{
    public class DeploymentSheetViewModel
    {
        public string RouteNo { get; set; }
        public string VehicleNo { get; set; }
        public List<DeploymentSheetModel> Deployments { get; set; }
    }

    public class DeploymentSheetModel
    {
        public int Id { get; set; }
        public string RouteNumber { get; set; }
        public Nullable<System.DateTime> DeploymentDate { get; set; }
        public string VehicleNo { get; set; }
        public Nullable<int> Substitute { get; set; }
        public Nullable<int> StaffId { get; set; }
        public Nullable<int> StaffType { get; set; }

        

    }
}

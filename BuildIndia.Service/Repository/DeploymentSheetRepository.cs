using BuildIndia.Data;
using BuildIndia.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildIndia.Service.Repository
{
    public class DeploymentSheetRepository : IDeploymentSheetRepository
    {
        public List<DeploymentSheetViewModel> InitDeploymentSheet()
        {
            var result = new List<DeploymentSheetViewModel>();
            using (var _context = new NasscomEntities())
            {
                var routes = _context.Route;
            }

            return result;
        }

        public void Save(List<DeploymentSheetModel> model)
        {
            using (var _context = new NasscomEntities())
            {
                foreach (var item in model)
                {

                    if (item.Id > 0)
                    {
                        var updatedEntity = _context.DeploymentSheet.Find(item.Id);

                        updatedEntity.Id = item.Id;
                        updatedEntity.RouteNumber = item.RouteNumber;
                        updatedEntity.DeploymentDate = item.DeploymentDate;
                        updatedEntity.VehicleNo = item.VehicleNo;
                        updatedEntity.Substitute = item.Substitute;
                        updatedEntity.StaffId = item.StaffId;
                        updatedEntity.StaffType = item.StaffType;

                        _context.Entry(updatedEntity).State = EntityState.Modified;

                    }
                    else
                    {
                        var entity = GetEntity(item);
                        _context.DeploymentSheet.Add(entity);
                    }
                    _context.SaveChanges();
                }
            }
        }

        private DeploymentSheet GetEntity(DeploymentSheetModel model)
        {
            DeploymentSheet result = new DeploymentSheet
            {
                Id = model.Id,
                RouteNumber = model.RouteNumber,
                DeploymentDate = model.DeploymentDate,
                VehicleNo = model.VehicleNo,
                Substitute = model.Substitute,
                StaffId = model.StaffId,
                StaffType = model.StaffType
            };
            return result;
        }
    }
}

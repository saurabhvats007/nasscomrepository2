using BuildIndia.Data;
using BuildIndia.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildIndia.Service.Repository
{
    public class RouteRepository
    {

        public void Save(RouteViewModel routeViewModel)
        {
            using (var _context = new NasscomEntities())
            {
                Route route = (from routes in _context.Route where routes.Id == routeViewModel.Id select routes).FirstOrDefault();
                if (route != null)
                {
                    route.CrewID = routeViewModel.CrewID;
                    route.DriverID = routeViewModel.DriverID;
                    route.Id = routeViewModel.Id;
                    route.Location = routeViewModel.Location;
                    route.RouteNumber = routeViewModel.RouteNumber;
                    route.VehicleNo = routeViewModel.VehicleNo;
                    route.WorkerID = routeViewModel.WorkerID;
                }
                else
                {
                    _context.Route.Add(GetEntity(routeViewModel));
                }

            }
        }

        public List<RouteViewModel> GetAllRoutes()
        {
            List<RouteViewModel> routes = null;
            using (var _context = new NasscomEntities())
            {
                routes = (from allroutes in _context.Route select GetModel(allroutes)).ToList();
            }
            if (routes != null)
            {
                return routes;
            }
            else
                return new List<RouteViewModel>();
        }

        public RouteViewModel GetRouteById(int id)
        {
            RouteViewModel route = null;

            using (var _context = new NasscomEntities())
            {
                route = (from allroutes in _context.Route where allroutes.Id == id select GetModel(allroutes)).FirstOrDefault();
            }
            if (route != null)
            {
                return route;
            }
            else
                return new RouteViewModel();

        }
        public RouteViewModel GetRouteByRouteNum(string routeNum)
        {
            RouteViewModel route = null;

            using (var _context = new NasscomEntities())
            {
                route = (from allroutes in _context.Route where allroutes.RouteNumber == routeNum select GetModel(allroutes)).FirstOrDefault();
            }
            if (route != null)
            {
                return route;
            }
            else
                return new RouteViewModel();

        }


        private Route GetEntity(RouteViewModel routeViewModel)
        {
            Route route = new Route()
            {
                CrewID = routeViewModel.CrewID,
                DriverID = routeViewModel.DriverID,
                WorkerID = routeViewModel.WorkerID,
                Id = routeViewModel.Id,
                Location = routeViewModel.Location,
                RouteNumber = routeViewModel.RouteNumber,
                VehicleNo = routeViewModel.VehicleNo
            };
            return route;
        }
        private RouteViewModel GetModel(Route routeViewModel)
        {
            RouteViewModel route = new RouteViewModel()
            {
                CrewID = routeViewModel.CrewID,
                DriverID = routeViewModel.DriverID,
                WorkerID = routeViewModel.WorkerID,
                Id = routeViewModel.Id,
                Location = routeViewModel.Location,
                RouteNumber = routeViewModel.RouteNumber,
                VehicleNo = routeViewModel.VehicleNo
            };
            return route;
        }
    }
}

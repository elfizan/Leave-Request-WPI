using LeaveRequestWebAPI.BussinessLogic.Service;
using LeaveRequestWebAPI.BussinessLogic.Service.Master;
using LeaveRequestWebAPI.Common.Repository;
using LeaveRequestWebAPI.Common.Repository.Master;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace LeaveRequestWebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            //this Service Only
            container.RegisterType<IProvinceService, ProvinceService>();
            container.RegisterType<IRegencyService, RegencyService>();
            container.RegisterType<IDistrictService, DistrictService>();
            container.RegisterType<IVillageService, VillageService>();
            //container.RegisterType<ILeaveService, LeaveService>();
            container.RegisterType<IDivisionService, DivisionService>();
            container.RegisterType<IHolidayService, HolidayService>();
            container.RegisterType<IPositionService, PositionService>();
            container.RegisterType<IEmployeeService, EmployeeService>();

            //this Repository Only
            container.RegisterType<IProvinceRepository, ProvinceRepository>();
            container.RegisterType<IRegencyRepository, RegencyRepository>();
            container.RegisterType<IDistrictRepository, DistrictRepository>();
            container.RegisterType<IVillageRepository, VillageRepository>();
            //container.RegisterType<ILeaveRepository, LeaveRepository>();
            container.RegisterType<IDivisionRepository, DivisionRepository>();
            container.RegisterType<IHolidayRepository, HolidayRepository>();
            container.RegisterType<IPositionRepository, PositionRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
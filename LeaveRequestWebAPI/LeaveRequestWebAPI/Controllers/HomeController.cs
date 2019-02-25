using LeaveRequestWebAPI.DataAccess.Context;
using LeaveRequestWebAPI.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveRequestWebAPI.Controllers
{
    public class HomeController : Controller
    {
        MyContext myContext = new MyContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //public ActionResult Login (Employee objEmp, string returnUrl)
        //{
        //    var data = myContext.Employees.Where(x => x.Username == objEmp.Username && x.Password == objEmp.Password).First();
        //    if (data != null)
        //    {
        //        FormAuthentication.Set
        //    }
        //}
    }
}

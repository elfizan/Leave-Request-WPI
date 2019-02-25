using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveRequestWebAPI.Client.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            if (Session["uname"] == null)
            {
                return Redirect("~/Login/Login");
            }
            else
            {
                return Content("Welcome " + Session["uname"]);
            }

            //return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        //public ActionResult AuthenticatedLogin (Employees employees)
        //{
        //    if (employees.Username != "" && employees.Password != "")
        //    {
        //        Session["uname"] = employees.Username;
        //        Session.Timeout = 10;
        //        return RedirectToAction("Index");
        //    }
        //}
    }
}
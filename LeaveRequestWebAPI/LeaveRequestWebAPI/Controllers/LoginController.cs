using LeaveRequestWebAPI.Common.Repository;
using LeaveRequestWebAPI.DataAccess.Context;
using LeaveRequestWebAPI.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LeaveRequestWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        MyContext myContext = new MyContext();
        Employee employess = new Employee();
        private readonly IEmployeeRepository _employeeRepository;
        public LoginController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: api/Login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
        [HttpGet]
        public Employee Login(string username, string password)
        {
            var get = _employeeRepository.Login(username, password);
            if (employess.Username == username && employess.Password == password)
            {
                //Session["uname"] =employess.Username;
                //Session.Timeout = 10;
                //return RedirectToAction("Index");
            }
            return get;
            
            //return null;
        }

    }
}

﻿using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service
{
    public interface IEmployeeService
    {
        bool Insert(EmployeeParam employeeParam);
        bool Update(int? Id, EmployeeParam employeeParam);
        bool Delete(int? Id);
        List<Employee> Get();
        Employee Get(int? Id);
        Employee Login(string Username, string Password);
    }
}

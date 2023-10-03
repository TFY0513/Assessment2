
using Microsoft.AspNetCore.Mvc;
using Assessment2.DBContext;
using Assessment2.Misc;
using System.Linq;
using Assessment2.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System;

namespace Assessment2.Controllers
{
    public class DemoDataController : Controller
    {
        private readonly DemoDBContext _dbContext;

        //public DemoDataController(DemoDBContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}
        public IActionResult DemoData()
        {

            var listEmployee = new EmployeeModel();
            listEmployee.Employees = new List<EmployeeModel>();
            var ds = EmployeeDB.GetEmployee();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var employee = new EmployeeModel();
                employee.Name = dr["Name"].ToString();
                employee.Age = Convert.ToInt32(dr["Age"].ToString());

                employee.Departments = new DepartmentModel();
                employee.Departments.Designation = dr["designation"].ToString();
                listEmployee.Employees.Add(employee);
            }
            return View(listEmployee);
        }
    }
}

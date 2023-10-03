using Assessment2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Assessment2.Repository
{
    public class EmployeeRepo
    {
        //public List<EmployeeModel> GetEmployeesWithDepartments()
        //{
        //    // Implement your LINQ query to fetch data from both tables
        //    var query = from emp in _dbContext.Employees
        //                join dept in _dbContext.Departments on emp.Id equals dept.empId
        //                where emp.Name == "Anthony" || emp.Name == "Peter"
        //                select new EmployeeModel
        //                {
        //                    Id = emp.Id,
        //                    Name = emp.Name,
        //                    Age = emp.Age,
        //                    Departments = new List<DepartmentModel>
        //                {
        //                    new DepartmentModel
        //                    {
        //                        empId = dept.empId,
        //                        Designation = dept.Designation
        //                    }
        //                }
        //                };

        //    return query.ToList();
        //}
    }
}

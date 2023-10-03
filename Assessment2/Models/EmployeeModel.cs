using System.Collections.Generic;

namespace Assessment2.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public DepartmentModel Departments { get; set; }

        public List<EmployeeModel> Employees { get; set; }
    }
}

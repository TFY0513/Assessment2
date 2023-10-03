using System.Collections.Generic;
using Assessment2.Models;
using Microsoft.EntityFrameworkCore;
namespace Assessment2.DBContext
{
    public class DemoDBContext : DbContext
    {
        public DemoDBContext()
        {
        }

        public DemoDBContext(DbContextOptions<DemoDBContext> options) : base(options)
        {
        }

        public DbSet<EmployeeModel> Employees { get; set; }
   
    }
}

using Microsoft.EntityFrameworkCore;
using Employee_DAL.Model;

namespace Employee_DAL
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> ?Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ProductSampleDBTest;Trusted_Connection=True;Connection Timeout=100");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
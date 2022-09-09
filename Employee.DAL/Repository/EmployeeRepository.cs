using Employee_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_DAL.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        protected EmployeeContext _context;

        public EmployeeRepository()
        {
            _context = new EmployeeContext();
        }

        public Task<bool> CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Task.FromResult(true);
        }

        public Task<List<Employee>> GetEmployee()
        {
            return Task.FromResult(_context.Employees.ToList<Employee>());
        }
    }
}

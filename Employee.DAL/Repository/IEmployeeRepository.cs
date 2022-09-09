using Employee_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_DAL.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployee();
        Task<bool> CreateEmployee(Employee employee);
    }
}

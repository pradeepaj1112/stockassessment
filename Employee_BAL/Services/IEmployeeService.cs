using Employee_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_BAL.Repository
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployee();
        Task<bool> CreateEmployee(Employee employee);
    }
}

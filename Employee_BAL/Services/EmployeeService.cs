using Employee_BAL.Repository;
using Employee_DAL.Model;
using Employee_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_BAL.Services
{
    public class EmployeeService : IEmployeeService
    {
        protected IEmployeeRepository _repository;

        public EmployeeService()
        //public ProductService(IProductRepository productRepository)

        {
            _repository = new EmployeeRepository();
            //    _repository = productRepository;
        }
        public Task<bool> CreateEmployee(Employee employee)
        {
            return _repository.CreateEmployee(employee);
        }

        public Task<List<Employee>> GetEmployee()
        {
            return _repository.GetEmployee();
        }

      
    }
}

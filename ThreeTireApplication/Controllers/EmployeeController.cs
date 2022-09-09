using Employee_BAL.Repository;
using Employee_BAL.Services;
using Employee_DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace ThreeTireApplication.Controllers
{
    


        [Route("api/[controller]")]
        [ApiController]
        public class EmployeeController : Controller
        {
        protected IEmployeeService _service;

            public EmployeeController(IEmployeeService EmployeeService)
            {
                _service = EmployeeService;
            }
            // GET: api/<ProductController>
            [HttpGet]
            public Task<List<Employee>> Get()
            {
                return _service.GetEmployee();
            }

            // POST api/<ProductController>
            [HttpPost]
            public void Post(Employee employee)
            {
                _service.CreateEmployee(employee);
            }


        }
}

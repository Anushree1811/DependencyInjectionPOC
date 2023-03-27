using DependencyInjectionPOC.Interfaces;
using DependencyInjectionPOC.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employee;
        public EmployeeController(IEmployeeService employee)
        {
            _employee = employee;
        }



        [HttpGet("GetEmployeeName")]
        public Employee GetEmployeeName(int id)
        {
            try
            {
                Employee result = _employee.GetEmployee(id);

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return null;
        }
    }
}

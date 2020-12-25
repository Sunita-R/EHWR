using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Employee;
using EHWR.Domain.DomainModel.Job;
using EHWR.Domain.DTO.Employee;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Employee;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.Controllers.Employee
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService EmployeeService)
        {
            _employeeService = EmployeeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] Search search)
        {
            IEnumerable<EmployeeModel> collection = await _employeeService.CollectionAsync(search);
            return Ok(collection);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee([FromQuery] Delete delete)
        {
            SpResponse deleteEmployee = await _employeeService.DeleteEmployeeAsync(delete);
            return Ok(deleteEmployee);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromQuery] AddEmployeeDTO model)
        {
            SpResponse addEmployee = await _employeeService.AddEmployeeAsync(model);
            return Ok(addEmployee);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee ([FromQuery] UpdateEmployeeDTO model)
        {
            SpResponse updateEmployee = await _employeeService.UpdateEmployeeAsync(model);
            return Ok(updateEmployee);
        }
    }
}

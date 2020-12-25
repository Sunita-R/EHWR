using EHWR.Domain.BusinessRules.Employee;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Employee;
using EHWR.Domain.DomainModel.Job;
using EHWR.Domain.DTO.Employee;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<SpResponse> AddEmployeeAsync(AddEmployeeDTO addEmployeeDTO)
        {
            return await _employeeRepository.AddEmployeeAsync(addEmployeeDTO);
        }

        public async Task<IEnumerable<EmployeeModel>> CollectionAsync(Search search)
        {
            return await _employeeRepository.CollectionAsync(search);
        }

        public async Task<SpResponse> DeleteEmployeeAsync(Delete delete)
        {
            return await _employeeRepository.DeleteEmployeeAsync(delete);
        }

        public async Task<SpResponse> UpdateEmployeeAsync(UpdateEmployeeDTO updateEmployeeDTO)
        {
            return await _employeeRepository.UpdateEmployeeAsync(updateEmployeeDTO);
        }
    }
}

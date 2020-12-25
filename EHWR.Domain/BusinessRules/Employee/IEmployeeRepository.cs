using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Employee;
using EHWR.Domain.DomainModel.Job;
using EHWR.Domain.DTO.Employee;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules.Employee
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeModel>> CollectionAsync(Search search);

        Task<SpResponse> AddEmployeeAsync(AddEmployeeDTO addEmployeeDTO);
        Task<SpResponse> UpdateEmployeeAsync(UpdateEmployeeDTO updateEmployeeDTO);
        Task<SpResponse> DeleteEmployeeAsync(Delete delete);
    }
}

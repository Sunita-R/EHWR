using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Employee;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Employee;
using EHWR.Domain.DomainModel.Job;
using EHWR.Domain.DTO.Employee;
using EHWR.Domain.Response;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Employee
{
    public class EmployeeRepository : GenericRepository, IEmployeeRepository
    {
        public EmployeeRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<SpResponse> AddEmployeeAsync(AddEmployeeDTO addEmployeeDTO)
        {
            return await CommandAsync<SpResponse>("AddEmployee", addEmployeeDTO);
        }

        public async Task<IEnumerable<EmployeeModel>> CollectionAsync(Search search)
        {
            return await CollectionsAsync<EmployeeModel>("GetEmployeeList", search);
        }

        public async Task<SpResponse> DeleteEmployeeAsync(Delete delete)
        {
            return await CommandAsync<SpResponse>("DeleteEmployee", delete);
        }

        public async Task<SpResponse> UpdateEmployeeAsync(UpdateEmployeeDTO updateEmployeeDTO)
        {
            return await CommandAsync<SpResponse>("UpdateEmployee", updateEmployeeDTO);
        }
    }
}

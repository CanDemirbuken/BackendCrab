using BackendCrab.Core.DTOs;
using BackendCrab.Core.DTOs.EmployeeDTOs;
using BackendCrab.EntityLayer.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCrab.Core.Services
{
    public interface IEmployeeService : IGenericService<Employee, EmployeeDTO>
    {
        Task<CustomResponseDTO<List<EmployeeDTO>>> GetEmployeesWithCompanyAsync();
        Task<CustomResponseDTO<EmployeeDTO>> AddAsync(EmployeeCreateDTO employeeCreateDTO);
        Task<CustomResponseDTO<NoContentDTO>> UpdateAsync(EmployeeUpdateDTO employeeUpdateDTO);
    }
}

using BackendCrab.Core.DTOs.CompanyDTOs;
using BackendCrab.Core.DTOs.EmployeeDTOs;
using BackendCrab.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendCrab.Api.Controllers
{
    public class EmployeeController : CustomBaseController
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _service.GetAllAsync();
            return CreateActionResult(employees);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetEmployeesWithCompany()
        {
            var employees = await _service.GetEmployeesWithCompanyAsync();
            return CreateActionResult(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanyById(int id)
        {
            var employee = await _service.GetByIdAsync(id);
            return CreateActionResult(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Save(EmployeeCreateDTO employeeCreateDTO)
        {
            var employee = await _service.AddAsync(employeeCreateDTO);
            return CreateActionResult(employee);
        }

        [HttpPut]
        public async Task<IActionResult> Update(EmployeeUpdateDTO employeeUpdateDTO)
        {
            var employee = await _service.UpdateAsync(employeeUpdateDTO);
            return CreateActionResult(employee);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var employee = await _service.RemoveAsync(id);
            return CreateActionResult(employee);
        }
    }
}

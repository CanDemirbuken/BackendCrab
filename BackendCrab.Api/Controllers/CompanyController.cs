using BackendCrab.Core.DTOs.CompanyDTOs;
using BackendCrab.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendCrab.Api.Controllers
{
    public class CompanyController : CustomBaseController
    {
        private readonly ICompanyService _service;

        public CompanyController(ICompanyService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var companies = await _service.GetAllAsync();
            return CreateActionResult(companies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanyById(int id)
        {
            var company = await _service.GetByIdAsync(id);
            return CreateActionResult(company);
        }

        [HttpPost]
        public async Task<IActionResult> Save(CompanyDTO companyDTO)
        {
            var company = await _service.AddAsync(companyDTO);
            return CreateActionResult(company);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CompanyDTO companyDTO)
        {
            var company = await _service.UpdateAsync(companyDTO);
            return CreateActionResult(company);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var company = await _service.RemoveAsync(id);
            return CreateActionResult(company);
        }
    }
}

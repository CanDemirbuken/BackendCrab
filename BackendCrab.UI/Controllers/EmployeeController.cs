using BackendCrab.Core.DTOs.EmployeeDTOs;
using BackendCrab.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BackendCrab.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeApiService _service;
        private readonly CompanyApiService _companyApiService;

        public EmployeeController(EmployeeApiService service, CompanyApiService companyApiService)
        {
            _service = service;
            _companyApiService = companyApiService;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await _service.GetAllAsync();
            return View(employees);
        }

        [HttpGet]
        public async Task<IActionResult> Save()
        {
            var companies = await _companyApiService.GetAllAsync();
            ViewBag.companies = new SelectList(companies, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(EmployeeCreateDTO employeeCreateDTO)
        {
            if (ModelState.IsValid)
            {
                await _service.SaveAsync(employeeCreateDTO);
                return RedirectToAction(nameof(Index));
            }

            var companies = await _companyApiService.GetAllAsync();
            ViewBag.companies = new SelectList(companies, "Id", "Name");
            return View();

        }

        public async Task<IActionResult> Update(int id)
        {
            var employeeDTO = await _service.GetByIdUpdateAsync(id);
            var companies = await _companyApiService.GetAllAsync();
            ViewBag.companies = new SelectList(companies, "Id", "Name", employeeDTO.CompanyId);

            return View(employeeDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Update(EmployeeUpdateDTO employeeDTO)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateAsync(employeeDTO);
                return RedirectToAction(nameof(Index));
            }

            var companies = await _companyApiService.GetAllAsync();
            ViewBag.companies = new SelectList(companies, "Id", "Name", employeeDTO.CompanyId);
            return View(employeeDTO);
        }


        public async Task<IActionResult> Remove(int id)
        {
            await _service.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

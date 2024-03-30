using BackendCrab.Core.DTOs.CompanyDTOs;
using BackendCrab.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendCrab.UI.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyApiService _service;

        public CompanyController(CompanyApiService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var companies = await _service.GetAllAsync();
            return View(companies);
        }

        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(CompanyCreateDTO companyCreateDTO)
        {
            if (ModelState.IsValid)
            {
                await _service.SaveAsync(companyCreateDTO);
                return RedirectToAction(nameof(Index));
            }

            return View(companyCreateDTO);

        }

        public async Task<IActionResult> Update(int id)
        {
            var companyDto = await _service.GetByIdAsync(id);
            return View(companyDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CompanyDTO companyDTO)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateAsync(companyDTO);
                return RedirectToAction(nameof(Index));
            }

            return View(companyDTO);
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _service.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

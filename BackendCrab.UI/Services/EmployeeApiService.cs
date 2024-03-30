using BackendCrab.Core.DTOs;
using BackendCrab.Core.DTOs.EmployeeDTOs;

namespace BackendCrab.UI.Services
{
    public class EmployeeApiService
    {
        private readonly HttpClient _httpClient;

        public EmployeeApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<EmployeeDTO>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDTO<List<EmployeeDTO>>>("employee/GetEmployeesWithCompany");
            return response.Data;
        }

        public async Task<EmployeeDTO> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDTO<EmployeeDTO>>($"employee/{id}");
            return response.Data;
        }

        public async Task<EmployeeUpdateDTO> GetByIdUpdateAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDTO<EmployeeUpdateDTO>>($"employee/{id}");
            return response.Data;
        }

        public async Task<EmployeeDTO> SaveAsync(EmployeeCreateDTO employeeDto)
        {
            var response = await _httpClient.PostAsJsonAsync("employee", employeeDto);
            if (!response.IsSuccessStatusCode) return null;

            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDTO<EmployeeDTO>>();
            return responseBody.Data;
        }

        public async Task<bool> UpdateAsync(EmployeeUpdateDTO employeeDto)
        {
            var response = await _httpClient.PutAsJsonAsync("employee", employeeDto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"employee/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}

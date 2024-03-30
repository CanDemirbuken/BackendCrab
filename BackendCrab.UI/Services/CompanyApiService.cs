using BackendCrab.Core.DTOs;
using BackendCrab.Core.DTOs.CompanyDTOs;

namespace BackendCrab.UI.Services
{
    public class CompanyApiService
    {
        private readonly HttpClient _httpClient;
        public CompanyApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CompanyDTO>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDTO<List<CompanyDTO>>>("company");
            return response.Data;
        }

        public async Task<CompanyDTO> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDTO<CompanyDTO>>($"company/{id}");
            return response.Data;
        }

        public async Task<CompanyDTO> SaveAsync(CompanyCreateDTO companyDto)
        {
            var response = await _httpClient.PostAsJsonAsync("company", companyDto);
            if (!response.IsSuccessStatusCode) return null;

            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDTO<CompanyDTO>>();
            return responseBody.Data;
        }

        public async Task<bool> UpdateAsync(CompanyDTO companyDto)
        {
            var response = await _httpClient.PutAsJsonAsync("company", companyDto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"company/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}

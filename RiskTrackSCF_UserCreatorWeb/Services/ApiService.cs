using System.Net.Http.Json;
using RiskTrackSCF_UserCreatorWeb.Models;

namespace RiskTrackSCF_UserCreatorWeb.Services
{
    public class ApiService
    {
        private readonly HttpClient _http;

        public ApiService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Company>> GetCompaniesAsync()
        {
            return await _http.GetFromJsonAsync<List<Company>>("api/companies") ?? new List<Company>();
        }

        public async Task<Company?> GetCompanyByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<Company>($"api/companies/{id}");
        }

        public async Task CreateCompanyAsync(Company company)
        {
            var response = await _http.PostAsJsonAsync("api/companies", company);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateCompanyAsync(Company company)
        {
            var response = await _http.PutAsJsonAsync($"api/companies/{company.CompanyId}", company);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteCompanyAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/companies/{id}");
            response.EnsureSuccessStatusCode();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _http.GetFromJsonAsync<List<User>>("api/users") ?? new List<User>();
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<User>($"api/users/{id}");
        }

        public async Task CreateUserAsync(User user)
        {
            var response = await _http.PostAsJsonAsync("api/users", user);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateUserAsync(User user)
        {
            var response = await _http.PutAsJsonAsync($"api/users/{user.UserId}", user);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteUserAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/users/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}

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

        public async Task CreateCompanyAsync(Company company)
        {
            await _http.PostAsJsonAsync("api/companies", company);
        }

        public async Task CreateUserAsync(User user)
        {
            await _http.PostAsJsonAsync("api/users", user);
        }
    }
}

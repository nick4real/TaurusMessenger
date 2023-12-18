using System.Text;
using System.Text.Json;
using TaurusMessenger.Shared.Model;

namespace TaurusMessengerClient.Service
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        private const string AuthStateKey = "AuthState";
        private const string AuthTokenKey = "AuthToken";

        public async Task<bool> IsAuthenticatedAsync()
        {
            await Task.Delay(2000);

            var authState = Preferences.Default.Get<bool>(AuthStateKey, false);

            return authState;
        }
        public async Task<bool> Login(UserAuthData user)
        {
            var json = JsonSerializer.Serialize(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"https://localhost:7094/api/auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();

                Preferences.Default.Set<bool>(AuthStateKey, true);
                Preferences.Default.Set<string>(AuthTokenKey, responseContent);
                return true;
            }

            return false;
        }

        public void Logout()
        {
            Preferences.Default.Remove(AuthStateKey);
            Preferences.Default.Remove(AuthTokenKey);
        }
    }
}

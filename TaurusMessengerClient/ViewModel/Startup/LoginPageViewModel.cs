using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.SignalR.Client;
using TaurusMessenger.Shared.Model;
using TaurusMessengerClient.Service;
using TaurusMessengerClient.View.Chats;

namespace TaurusMessengerClient.ViewModel.Startup
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        public string login;
        [ObservableProperty]
        public string password;
        [ObservableProperty]
        public string message;

        private readonly AuthService _authService;
        public LoginPageViewModel(AuthService authService)
        {
            _authService = authService;
        }

        [RelayCommand]
        async Task SignIn()
        {
            UserAuthData authData = new();
            authData.Login = login;
            authData.Password = password;

            if (await _authService.Login(authData))
                await Shell.Current.GoToAsync($"//{nameof(ChatsPage)}");
            else 
                Message = "Error: invalid input";
        }

        [RelayCommand]
        async Task Signal()
        {
            try
            {
                var _myAccessToken = login;

                if (String.IsNullOrWhiteSpace(login))
                {
                    _myAccessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9" +
                    ".eyJpc3MiOiJodHRwczovL2dpdGh1Yi5jb20vbmljazRyZWFsIiwiYXVkIjpbImh0dHBzOi8vdGF1cnVzLmNvbSIsImh0dHBzOi8vdGF1cnVzLmNvbSJdLCJleHAiOjE3MDI5NDMxMjJ9" +
                    ".ObzOtlgyg5DCVZXpGcHkJGbgkIiKmcHqgMf8MLb7QzQ";
                }

                var connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7094/hub", options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(_myAccessToken);
                    options.UseDefaultCredentials = true;
                })
                .Build();

                await connection.StartAsync();

                await connection.InvokeAsync("SendMessage");
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}

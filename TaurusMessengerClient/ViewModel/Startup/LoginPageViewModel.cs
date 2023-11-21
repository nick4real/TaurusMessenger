using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

        private readonly AuthService _authService;
        public LoginPageViewModel(AuthService authService)
        {
            _authService = authService;
        }

        [RelayCommand]
        async Task SignIn()
        {
            _authService.Login();
            await Shell.Current.GoToAsync($"//{nameof(ChatsPage)}");
        }
    }
}

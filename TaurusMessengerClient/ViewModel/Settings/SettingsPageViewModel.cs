using CommunityToolkit.Mvvm.Input;
using TaurusMessengerClient.Service;
using TaurusMessengerClient.View.Startup;

namespace TaurusMessengerClient.ViewModel.Settings
{
    public partial class SettingsPageViewModel : BaseViewModel
    {
        private readonly AuthService _authService;
        public SettingsPageViewModel(AuthService authService)
        {
            _authService = authService;
        }

        [RelayCommand]
        async Task Logout()
        {
            _authService.Logout();
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        } 
    }
}

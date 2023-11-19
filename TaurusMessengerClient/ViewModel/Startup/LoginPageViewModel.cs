using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TaurusMessengerClient.ViewModel.Startup
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        public string login;
        [ObservableProperty]
        public string password;

        [RelayCommand]
        async void SignIn()
        {

        }
    }
}

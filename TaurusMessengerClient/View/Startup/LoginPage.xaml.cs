using TaurusMessengerClient.ViewModel.Startup;

namespace TaurusMessengerClient.View.Startup;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel loginPageViewModel)
	{
		InitializeComponent();
		BindingContext = loginPageViewModel;
	}
}
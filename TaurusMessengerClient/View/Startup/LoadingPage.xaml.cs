using TaurusMessengerClient.Service;
using TaurusMessengerClient.View.Chats;
using TaurusMessengerClient.ViewModel.Startup;

namespace TaurusMessengerClient.View.Startup;

public partial class LoadingPage : ContentPage
{
    private readonly AuthService _authService;
    public LoadingPage(LoadingPageViewModel loadingPageViewModel, AuthService authService)
	{
		InitializeComponent();
        BindingContext = loadingPageViewModel;
        _authService = authService;
    }
    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (await _authService.IsAuthenticatedAsync())
        {
            await Shell.Current.GoToAsync($"//{nameof(ChatsPage)}");
        }
        else
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
using TaurusMessengerClient.ViewModel.Startup;

namespace TaurusMessengerClient.View.Startup;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingPageViewModel loadingPageViewModel)
	{
		InitializeComponent();
        BindingContext = loadingPageViewModel;
    }
}
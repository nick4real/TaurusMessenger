using TaurusMessengerClient.ViewModel.Settings;

namespace TaurusMessengerClient.View.Settings;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsPageViewModel settingsPageViewModel)
	{
		InitializeComponent();

		BindingContext = settingsPageViewModel;
	}
}
using TaurusMessengerClient.ViewModel;

namespace TaurusMessengerClient.View;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsPageViewModel settingsPageViewModel)
	{
		InitializeComponent();

		BindingContext = settingsPageViewModel;
	}
}
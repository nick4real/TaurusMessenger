using TaurusMessengerClient.ViewModel;

namespace TaurusMessengerClient.View;

public partial class ContactsPage : ContentPage
{
	public ContactsPage(SettingsPageViewModel newPageViewModel)
	{
		InitializeComponent();

		BindingContext = newPageViewModel;
	}
}
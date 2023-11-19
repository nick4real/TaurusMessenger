using TaurusMessengerClient.ViewModel.Contacts;

namespace TaurusMessengerClient.View.Contacts;

public partial class ContactsPage : ContentPage
{
	public ContactsPage(ContactsPageViewModel newPageViewModel)
	{
		InitializeComponent();

		BindingContext = newPageViewModel;
	}
}
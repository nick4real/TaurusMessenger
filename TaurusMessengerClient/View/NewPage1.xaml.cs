using TaurusMessengerClient.ViewModel;

namespace TaurusMessengerClient.View;

public partial class NewPage1 : ContentPage
{
	public NewPage1(NewPageViewModel newPageViewModel)
	{
		InitializeComponent();
		BindingContext = newPageViewModel;
	}
}
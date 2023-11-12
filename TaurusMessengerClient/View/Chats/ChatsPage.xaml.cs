using TaurusMessengerClient.ViewModel;

namespace TaurusMessengerClient.View;

public partial class ChatsPage : ContentPage
{
	public ChatsPage(ChatsPageViewModel chatsPageViewModel)
	{
		InitializeComponent();
		BindingContext = chatsPageViewModel;
    }
}
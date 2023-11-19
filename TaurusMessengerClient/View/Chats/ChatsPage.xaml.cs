using TaurusMessengerClient.ViewModel.Chats;

namespace TaurusMessengerClient.View.Chats;

public partial class ChatsPage : ContentPage
{
    public ChatsPage(ChatsPageViewModel chatsPageViewModel)
    {
        InitializeComponent();
        BindingContext = chatsPageViewModel;
    }
}
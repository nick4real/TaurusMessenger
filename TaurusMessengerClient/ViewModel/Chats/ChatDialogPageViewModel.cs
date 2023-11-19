using CommunityToolkit.Mvvm.ComponentModel;
using TaurusMessenger.Shared.Model;

namespace TaurusMessengerClient.ViewModel.Chats
{
    [QueryProperty(nameof(User), nameof(User))]
    public partial class ChatDialogPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        User user;
    }
}

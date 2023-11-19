using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TaurusMessenger.Shared.Model;
using TaurusMessengerClient.View.Chats;

namespace TaurusMessengerClient.ViewModel.Chats
{
    public partial class ChatsPageViewModel : BaseViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        [RelayCommand]
        async Task GoToNewPage()
        {
            await Shell.Current.GoToAsync(nameof(ChatDialogPage));
        }

        async Task Navigate() => await Shell.Current.GoToAsync($"{nameof(ChatDialogPage)}");

        public ChatsPageViewModel()
        {
            Users = new ObservableCollection<User>()
            {
                new User(),
                new User(),
                new User()
            };
        }
    }
}
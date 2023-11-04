using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TaurusMessengerClient.View;

namespace TaurusMessengerClient.ViewModel
{
    public partial class NewPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task GoToNewPage()
        {
            await Shell.Current.GoToAsync("NewPage");
        }

        public NewPageViewModel()
        {
            Text = "Some random lipsum text";
        }
    }
}

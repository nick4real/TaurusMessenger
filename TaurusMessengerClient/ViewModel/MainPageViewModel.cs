﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TaurusMessengerClient.View;

namespace TaurusMessengerClient.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task GoToNewPage()
        {
            await Shell.Current.GoToAsync(nameof(NewPage1));
        }

        public MainPageViewModel()
        {
            Text = "Some random lipsum text";
        }
    }
}

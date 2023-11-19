using Microsoft.Extensions.Logging;
using TaurusMessengerClient.Service;
using TaurusMessengerClient.View.Chats;
using TaurusMessengerClient.View.Contacts;
using TaurusMessengerClient.View.Settings;
using TaurusMessengerClient.View.Startup;
using TaurusMessengerClient.ViewModel.Chats;
using TaurusMessengerClient.ViewModel.Contacts;
using TaurusMessengerClient.ViewModel.Settings;
using TaurusMessengerClient.ViewModel.Startup;

namespace TaurusMessengerClient
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("fontello.ttf", "Icons");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            //Service
            builder.Services.AddSingleton<DataService>();
            //Startup
            builder.Services.AddTransient<LoadingPage>();
            builder.Services.AddTransient<LoadingPageViewModel>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<LoginPageViewModel>();
            //Chats
            builder.Services.AddTransient<ChatsPage>();
            builder.Services.AddTransient<ChatsPageViewModel>();
            builder.Services.AddTransient<ChatDialogPage>();
            builder.Services.AddTransient<ChatDialogPageViewModel>();
            //Contacts
            builder.Services.AddTransient<ContactsPage>();
            builder.Services.AddTransient<ContactsPageViewModel>();
            //Settings
            builder.Services.AddTransient<SettingsPage>();
            builder.Services.AddTransient<SettingsPageViewModel>();

            return builder.Build();
        }
    }
}
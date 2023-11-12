using Microsoft.Extensions.Logging;
using TaurusMessengerClient.ViewModel;
using TaurusMessengerClient.View;

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
            builder.Services.AddSingleton<App>();

            builder.Services.AddTransient<ChatsPageViewModel>();
            builder.Services.AddTransient<ChatsPage>();

            builder.Services.AddTransient<ContactsPageViewModel>();
            builder.Services.AddTransient<ContactsPage>();

            builder.Services.AddTransient<SettingsPageViewModel>();
            builder.Services.AddTransient<SettingsPage>();
            return builder.Build();
        }
    }
}
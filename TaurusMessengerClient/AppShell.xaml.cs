using TaurusMessengerClient.View.Chats;
using TaurusMessengerClient.View.Contacts;
using TaurusMessengerClient.View.Settings;
using TaurusMessengerClient.View.Startup;

namespace TaurusMessengerClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute($"//{nameof(LoginPage)}", typeof(LoginPage));
            Routing.RegisterRoute($"//{nameof(LoadingPage)}", typeof(LoginPage));

            //Chats
            Routing.RegisterRoute($"//{nameof(ChatsPage)}", typeof(ChatsPage));
            Routing.RegisterRoute($"//{nameof(ChatsPage)}/{nameof(ChatDialogPage)}", typeof(ChatDialogPage));

            //Contacts
            Routing.RegisterRoute($"//{nameof(ContactsPage)}", typeof(ContactsPage));

            //Settings
            Routing.RegisterRoute($"//{nameof(SettingsPage)}", typeof(SettingsPage));
        }
    }
}
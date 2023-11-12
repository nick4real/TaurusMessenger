using TaurusMessengerClient.View;

namespace TaurusMessengerClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute($"//{nameof(ContactsPage)}", typeof(ContactsPage));
            Routing.RegisterRoute($"//{nameof(SettingsPage)}", typeof(SettingsPage));
            Routing.RegisterRoute($"//{nameof(ChatsPage)}", typeof(ChatsPage));
        }
    }
}
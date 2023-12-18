using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace TaurusMessengerServer.Hubs
{
    [Authorize]
    public class ChatHub : Hub //TODO: message exchange between clients
    {
        public override Task OnConnectedAsync()
        {
            Console.WriteLine("Someone connected. Great success!");
            return base.OnConnectedAsync();
        }
        public async Task SendMessage()
        {
            Console.WriteLine("SendMessage also works");
            await Clients.All.SendAsync("ReceiveMessage");
        }
    }
}

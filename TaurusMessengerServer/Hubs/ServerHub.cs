using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace TaurusMessengerServer.Hubs
{
    [Authorize]
    public class ServerHub : Hub
    {
        #region Hub override
        public override Task OnConnectedAsync()
        {
            Console.WriteLine(Context.User?.Identity?.Name + " connected. Great success!");
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            Console.WriteLine(Context.User?.Identity?.Name + " left us.");
            return base.OnDisconnectedAsync(exception);
        }
        #endregion
        #region Chat
        public async Task SendMessage()
        {
            Console.WriteLine("SendMessage also works");
            await Clients.All.SendAsync("ReceiveMessage");
        }
        #endregion
        #region Notification

        #endregion
        #region Presence

        #endregion
    }
}

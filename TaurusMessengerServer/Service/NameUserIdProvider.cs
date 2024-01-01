using Microsoft.AspNetCore.SignalR;

namespace TaurusMessengerServer.Service
{
    public class NameUserIdProvider : IUserIdProvider
    {
        public string GetUserId(HubConnectionContext connection)
        {
            return connection.User?.Identity?.Name!;
        }
    }
}

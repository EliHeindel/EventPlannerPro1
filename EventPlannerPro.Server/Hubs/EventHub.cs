using Microsoft.AspNetCore.SignalR;

namespace EventPlannerPro.Server.Hubs
{
    public class EventHub : Hub
    {
        public async Task SendEventUpdate(string message)
        {
            await Clients.All.SendAsync("ReceiveEventUpdate", message);
        }
    }
}

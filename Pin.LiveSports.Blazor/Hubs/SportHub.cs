using Microsoft.AspNetCore.SignalR;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class BoxingHub : Hub
    {
        //todo
        public async Task SendUpdate()
        {
            await Clients.Others.SendAsync("TODO", new { TODO = "TODO" });
        }
    }
}

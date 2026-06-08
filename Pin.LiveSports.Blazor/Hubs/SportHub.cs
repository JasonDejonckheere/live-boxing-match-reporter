using Microsoft.AspNetCore.SignalR;
using Pin.LiveSports.Blazor.Data;
using Pin.LiveSports.Blazor.Services;
using Pin.LiveSports.Core.Entities;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class BoxingHub : Hub
    {
        //todo
        public async Task AddMatchEvent(MatchStateEvent e)
        {
            await Clients.Others.SendAsync(BoxClient.REMOTE_MATCH_ADD, e);
        }
    }
}

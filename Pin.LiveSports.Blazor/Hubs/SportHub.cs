using Microsoft.AspNetCore.SignalR;
using Pin.LiveSports.Blazor.Data;
using Pin.LiveSports.Blazor.Services;
using Pin.LiveSports.Core.Entities;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class BoxingHub : Hub
    {
        //todo
        public async Task AddMatchStateEvent(MatchStateEvent e)
        {
            await Clients.Others.SendAsync(BoxClient.REMOTE_MATCH_STATE_EVENT, e);
        }
        public async Task AddMatchResultEvent(MatchResultEvent e)
        {
            await Clients.Others.SendAsync(BoxClient.REMOTE_MATCH_RESULT_EVENT, e);
        }
        public async Task AddMatchAttackEvent(MatchAttackEvent e)
        {
            await Clients.Others.SendAsync(BoxClient.REMOTE_MATCH_ATTACK_EVENT, e);
        }
    }
}

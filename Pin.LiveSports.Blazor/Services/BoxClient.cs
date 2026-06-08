using Microsoft.AspNetCore.SignalR.Client;
using Pin.LiveSports.Blazor.Data;
using Pin.LiveSports.Blazor.Hubs;
using Pin.LiveSports.Blazor.Pages;
using Pin.LiveSports.Core.Entities;

namespace Pin.LiveSports.Blazor.Services
{
    public class BoxClient
    {
        protected HubConnection connection;

        public const string REMOTE_MATCH_STATE_EVENT = nameof(AddRemoteMatchStateEvent);
        public const string REMOTE_MATCH_RESULT_EVENT = nameof(AddRemoteMatchResultEvent);
        public const string REMOTE_MATCH_ATTACK_EVENT = "AddRemoteMatchEvent";

        public BoxClient()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7005/sporthub")
                .Build();
        }

        public void Configure(
            Action<MatchStateEvent> callbackStateEvent,
            Action<MatchResultEvent> callbackResultEvent,
            Action<MatchAttackEvent> callbackAttackEvent
            )
        {
            connection.On(REMOTE_MATCH_STATE_EVENT, callbackStateEvent);
            connection.On(REMOTE_MATCH_RESULT_EVENT, callbackResultEvent);
            connection.On(REMOTE_MATCH_ATTACK_EVENT, callbackAttackEvent);
        }

        public async Task Start()
        {
            await connection.StartAsync();
        }

        //todo change BaseMatchEvent to interface type IMatchEvent

        public async Task AddRemoteMatchStateEvent(MatchStateEvent e)
        {
            await connection.SendAsync(nameof(BoxingHub.AddMatchStateEvent), e);
        }
        public async Task AddRemoteMatchResultEvent(MatchResultEvent e)
        {
            await connection.SendAsync(nameof(BoxingHub.AddMatchResultEvent), e);
        }
        public async Task AddRemoteMatchAttackEvent(MatchAttackEvent e)
        {
            await connection.SendAsync(nameof(BoxingHub.AddMatchAttackEvent), e);
        }
    }
}

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

        public const string REMOTE_MATCH_ADD = "AddRemoteMatchEvent";

        public BoxClient()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7005/sporthub")
                .Build();
        }

        public void Configure(Action<BaseMatchEvent> callback)
        {
            connection.On(REMOTE_MATCH_ADD, callback);
        }

        public async Task Start()
        {
            await connection.StartAsync();
        }

        public async Task AddRemoteMatchEvent(BaseMatchEvent e)
        {
            await connection.SendAsync(nameof(BoxingHub.AddMatchEvent), e);
        }

    }
}

using Microsoft.AspNetCore.SignalR.Client;

namespace Pin.LiveSports.Blazor.Services
{
    public class SportClient
    {
        protected HubConnection connection;

        public SportClient()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7005/sporthub")
                .Build();
        }

        public async Task Start()
        {
            await connection.StartAsync();
        }

        //todos update events
    }
}

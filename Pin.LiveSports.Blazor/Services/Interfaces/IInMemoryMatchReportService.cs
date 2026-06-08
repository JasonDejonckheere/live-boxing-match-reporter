using Pin.LiveSports.Blazor.Data;
using Pin.LiveSports.Blazor.Pages;

namespace Pin.LiveSports.Blazor.Services.Interfaces
{
    public interface IInMemoryMatchReportService
    {
        void Add(MatchReport matchReport);

        void Update(MatchReport matchReport);

        List<MatchStateEvent> GetEventsByMatchId(Guid matchId);

        List<MatchReport> GetAll();
    }
}

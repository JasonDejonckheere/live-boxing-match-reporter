using Pin.LiveSports.Blazor.Data;
using Pin.LiveSports.Blazor.Pages;

namespace Pin.LiveSports.Blazor.Services.Interfaces
{
    public interface IInMemoryMatchReportService
    {
        void Add(MatchReport matchReport);

        void Update(MatchReport matchReport);

        List<BaseMatchEvent> GetEventsByMatchId(Guid matchId);
        IEnumerable<BaseMatchEvent> GetLatestEventsByMatchId(Guid matchId, int latestCount);

        List<MatchReport> GetAll();
    }
}

using Pin.LiveSports.Blazor.Data;
using Pin.LiveSports.Blazor.Pages;
using Pin.LiveSports.Blazor.Services.Interfaces;

namespace Pin.LiveSports.Blazor.Services
{
    public class InMemoryMatchReportService : IInMemoryMatchReportService
    {
        private List<MatchReport> matchReports;

        public InMemoryMatchReportService()
        {
            matchReports = new();
        }

        public void Add(MatchReport matchReport)
        {
            if(matchReport is not null)
            {
                var existing = matchReports.FirstOrDefault(m => m.MatchId == matchReport.MatchId);
                if (existing is not null) matchReports.Remove(existing);
                matchReports.Add(matchReport);
            }                
        }

        public void Update(MatchReport matchReport)
        {
            if (matchReports.Any(m => m.MatchId == matchReport.MatchId))
            {
                Add(matchReport);
            }
        }

        public List<BaseMatchEvent> GetEventsByMatchId (Guid matchId)
        {
            return matchReports
                .FirstOrDefault(m => m.MatchId == matchId)?
                .MatchEvents ?? new();
        }

        public List<MatchReport> GetAll()
        {
            return matchReports;
        }

    }
}

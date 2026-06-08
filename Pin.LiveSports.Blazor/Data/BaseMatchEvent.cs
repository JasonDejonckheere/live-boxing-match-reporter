using Pin.LiveSports.Core.Entities;

namespace Pin.LiveSports.Blazor.Data
{
    public abstract class BaseMatchEvent
    {
        //not stored in db for this exam
        public Fighter Fighter { get; set; }
        public bool IsConcious { get; set; }
        public Guid MatchId { get; set; }
    }
}

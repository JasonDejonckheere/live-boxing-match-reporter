using Pin.LiveSports.Core.Entities;
using Pin.LiveSports.Core.Interfaces;

namespace Pin.LiveSports.Blazor.Data
{
    public class MatchResultEvent : IFightEvent
    {
        public Guid MatchId { get ; set; }
        public Fighter Fighter { get; set; }
        public bool IsConcious { get; set; }

        public override string ToString()
        {
            return $"{Fighter.Firstname} {Fighter.Lastname} won the match!";
        }
    }
}

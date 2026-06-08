using Pin.LiveSports.Blazor.Services.Interfaces;
using Pin.LiveSports.Core.Entities;
using Pin.LiveSports.Core.Interfaces;

namespace Pin.LiveSports.Blazor.Data
{
    public class MatchStateEvent : IFightEvent
    {
        //not stored in db for this exam
        public Fighter Fighter { get; set; }
        public bool IsConcious { get; set; }
        public Guid MatchId { get; set; }

        public override string ToString()
        {
            if(!IsConcious) return $"{Fighter.Firstname} {Fighter.Lastname} has been knocked out!";
            else return $"{Fighter.Firstname} {Fighter.Lastname} is back up!";
        }
    }
}

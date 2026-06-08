using Pin.LiveSports.Core.Entities;
using Pin.LiveSports.Core.Interfaces;

namespace Pin.LiveSports.Blazor.Data
{
    public class MatchEvent : IFightEvent
    {
        //not stored in db for this exam

        //could use class but for ease of use just using string
        public Guid MatchId { get; set; }
        public Fighter Fighter { get; set; }
        public bool IsConcious { get; set; }
        public string Limb { get; set; }
        public string ActionPerformed { get; set; }

        public override string ToString()
        {
            return $"{Fighter.Firstname} {Fighter.Lastname} attacked with a {Limb} {ActionPerformed}.";
        }
    }
}

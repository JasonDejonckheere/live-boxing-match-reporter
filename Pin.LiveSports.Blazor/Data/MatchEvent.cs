using Pin.LiveSports.Core.Entities;

namespace Pin.LiveSports.Blazor.Data
{
    public class MatchEvent : BaseMatchEvent
    {
        //not stored in db for this exam

        //could use class but for ease of use just using string
        public string Limb { get; set; }

        public string ActionPerformed { get; set; }

        public override string ToString()
        {
            return $"{Fighter.Firstname} {Fighter.Lastname} attacked with a {Limb} {ActionPerformed}.";
        }
    }
}

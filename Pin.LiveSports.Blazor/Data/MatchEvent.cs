using Pin.LiveSports.Core.Entities;

namespace Pin.LiveSports.Blazor.Data
{
    public class MatchEvent
    {
        //not stored in db for this exam
        public Fighter Fighter { get; set; }

        //could use class but for ease of use just using string
        public string Limb { get; set; }

        public string ActionPerformed { get; set; }
    }
}

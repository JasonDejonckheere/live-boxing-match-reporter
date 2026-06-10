namespace Pin.LiveSports.Blazor.Data
{
    public class MatchStateEvent : BaseMatchEvent
    {
        public override string ToString()
        {
            if (!IsConcious) return $"💥 {Fighter.Firstname} {Fighter.Lastname} has been knocked out!";
            else return $"🌟 {Fighter.Firstname} {Fighter.Lastname} is back up!";
        }
    }
}

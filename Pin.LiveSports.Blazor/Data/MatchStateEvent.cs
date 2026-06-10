namespace Pin.LiveSports.Blazor.Data
{
    public class MatchStateEvent : BaseMatchEvent
    {
        public override string ToString()
        {
            if (!IsConcious) return $"{base.ToString()} 💥 {Fighter.Firstname} {Fighter.Lastname} has been knocked out!";
            else return $"{base.ToString()} 🌟 {Fighter.Firstname} {Fighter.Lastname} is back up!";
        }
    }
}

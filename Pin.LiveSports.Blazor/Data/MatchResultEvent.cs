namespace Pin.LiveSports.Blazor.Data
{
    public class MatchResultEvent : BaseMatchEvent
    {
        public override string ToString()
        {
            return $"🏆 {Fighter.Firstname} {Fighter.Lastname} won the match!";
        }
    }
}

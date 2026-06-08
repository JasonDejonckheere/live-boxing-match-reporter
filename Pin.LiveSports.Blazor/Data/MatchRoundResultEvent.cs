
namespace Pin.LiveSports.Blazor.Data
{
    public class MatchRoundResultEvent : MatchResultEvent
    {
        public int RoundNumber { get; set; }

        public override string ToString()
        {
            return $"{Fighter.Firstname} {Fighter.Lastname} won round {RoundNumber}!";
        }
    }
}

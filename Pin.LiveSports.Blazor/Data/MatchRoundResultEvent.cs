
namespace Pin.LiveSports.Blazor.Data
{
    public class MatchRoundResultEvent : BaseMatchEvent
    {
        public int RoundNumber { get; set; }
        public int FighterScore { get; set; }
        public int ScoreBlue { get; set; }
        public int ScoreRed { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ⏳ {Fighter.Firstname} {Fighter.Lastname} won round {RoundNumber} and now has a score of {FighterScore}";
        }
    }
}

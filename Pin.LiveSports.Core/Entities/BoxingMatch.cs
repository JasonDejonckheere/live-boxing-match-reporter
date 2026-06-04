using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Entities
{
    public class BoxingMatch
    {
        public Guid Id { get; set; }

        public Guid FighterBlueTeamId { get; set; }
        public Fighter FighterBlueTeam { get; set; }

        public Guid FighterRedTeamId { get; set; }
        public Fighter FighterRedTeam { get; set; }


        public Guid? WinningFighterId { get; set; }
        public Fighter WinningFighter { get; set; }
        public bool IsFinished => WinningFighterId != null;
    }
}

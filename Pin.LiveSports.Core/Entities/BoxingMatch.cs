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
        public Guid? WinningFighterId { get; set; }
        public bool IsFinished => WinningFighterId != null;
        public ICollection<Fighter> Fighters { get; set; }
    }
}

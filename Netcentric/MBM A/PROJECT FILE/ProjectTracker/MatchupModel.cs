using System;
using System.Collectopn.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackerlibrary
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupModel();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}

using System;
using System.Collectopn.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackerlibrary
{
    public class TournamentModel
    {
        
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = newList<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
        
    }
}
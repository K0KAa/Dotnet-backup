using System;
using System.Collectopn.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackerlibrary
{
    public class MatchupEntryModel
    {
        /// 
        /// Represents one team in the matchup
        /// 

        public TeamModel TeamCompeting { get; set; } 

        ///
        /// Represents the score for this particular team
        ///

        public double Score { get; set; }

        ///
        /// Represents the match that this team came from
        /// as the winner

        ///

        public MatchupModel ParentMatchup {get; set; }



    }
}

using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the Entries for thi
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// Represents the winner of the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }


        public int MatchupRound { get; set; }
    }
}

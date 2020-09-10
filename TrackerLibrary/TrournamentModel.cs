using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TrournamentModel
    {
        /// <summary>
        /// Name of tournament.
        /// </summary>
        public string TrournamentName { get; set; }
        /// <summary>
        /// Cost to enter tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Teams entered into tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of Prizes.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// List of matchups.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}

using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// List of team members.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Name of team
        /// </summary>
        public string TeamName { get; set; }
    }
}

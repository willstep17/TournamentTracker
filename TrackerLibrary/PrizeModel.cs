using System;
namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The place for prize allocation.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Name of place.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Amount of prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage of prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}

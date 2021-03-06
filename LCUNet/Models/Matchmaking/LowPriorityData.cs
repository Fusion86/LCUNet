using System.Collections.Generic;

namespace LCUNet.Models.Matchmaking
{
    public class LowPriorityData
    {
        public string BustedLeaverAccessToken { get; set; }
        public List<long> PenalizedSummonerIds { get; set; }
        public double PenaltyTime { get; set; }
        public double PenaltyTimeRemaining { get; set; }
    }
}

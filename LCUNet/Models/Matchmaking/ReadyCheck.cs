using System.Collections.Generic;

namespace LCUNet.Models.Matchmaking
{
    public class ReadyCheck
    {
        public List<long> DeclinerIds { get; set; }
        public DodgeWarning DodgeWarning { get; set; }
        public ReadyCheckResponse PlayerResponse { get; set; }
        public ReadyCheckState State { get; set; }
        public bool SuppressUx { get; set; }
        public float Timer { get; set; }
    }

    public enum ReadyCheckResponse
    {
        None,
        Accepted,
        Declined
    }

    public enum ReadyCheckState
    {
        Invalid,
        InProgress,
        EveryoneReady,
        StrangerNotReady,
        PartyNotReady,
        Error
    }
}

namespace LCUNet.Definitions
{
    public class LolSummonerSummonerIcon : JsonSerializable
    {
        public int ProfileIconId { get; set; }
        
        public LolSummonerSummonerIcon(int id)
        {
            ProfileIconId = id;
        }
    }
}

namespace LCUNet.Models.GameData
{
    public class SummonerIconSet
    {
        public long Id { get; set; }
        public bool Hidden { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public long[] Icons { get; set; }
    }
}

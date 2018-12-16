namespace LCUNet.Models.GameData
{
    public class SummonerIcon
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearReleased { get; set; }
        public bool IsLegacy { get; set; }
        public string ImagePath { get; set; }
        public Description[] Descriptions { get; set; }
        public Rarity[] Rarities { get; set; }
        public object[] DisabledRegions { get; set; }
    }

    public class Description
    {
        public string Region { get; set; }
        public string DescriptionDescription { get; set; }
    }

    public class Rarity
    {
        public string Region { get; set; }
        public int RarityRarity { get; set; }
    }
}

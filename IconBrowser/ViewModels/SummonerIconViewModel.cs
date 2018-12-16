using LCUNet.Models.GameData;

namespace IconBrowser.ViewModels
{
    public class SummonerIconViewModel
    {
        public string Title { get; }
        public string ImagePath { get; } 

        public SummonerIconViewModel(SummonerIcon summonerIcon, string basePath)
        {
            Title = summonerIcon.Title;
            ImagePath = basePath + summonerIcon.ImagePath;
        }
    }
}

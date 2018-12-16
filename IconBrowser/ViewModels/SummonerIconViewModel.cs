using LCUNet.Models.GameData;
using System.Diagnostics;
using System.Windows;

namespace IconBrowser.ViewModels
{
    public class SummonerIconViewModel
    {
        public long Id => _summonerIcon.Id;
        public string Title => _summonerIcon.Title;
        public string ImagePath => _summonerIcon.ImagePath;

        public string FullPath { get; }

        #region Commands

        public RelayCommand CopyIconUrlCommand { get; }
        public RelayCommand OpenIconInBrowserCommand { get; }

        #endregion

        private SummonerIcon _summonerIcon;

        public SummonerIconViewModel(SummonerIcon summonerIcon, string basePath)
        {
            _summonerIcon = summonerIcon;

            FullPath = basePath + ImagePath;

            CopyIconUrlCommand = new RelayCommand(CopyIconUrl);
            OpenIconInBrowserCommand = new RelayCommand(OpenIconInBrowser);
        }

        private void CopyIconUrl()
        {
            Clipboard.SetText(FullPath);
        }

        private void OpenIconInBrowser()
        {
            Process.Start(FullPath);
        }
    }
}

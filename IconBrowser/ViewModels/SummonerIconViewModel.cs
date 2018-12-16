using LCUNet.Definitions;
using LCUNet.Models.GameData;
using System;
using System.Diagnostics;
using System.Windows;

namespace IconBrowser.ViewModels
{
    public class SummonerIconViewModel
    {
        public int Id => _summonerIcon.Id;
        public string Title => _summonerIcon.Title;
        public string ImagePath => _summonerIcon.ImagePath;

        public string FullPath { get; }

        #region Commands

        public RelayCommand CopyIconUrlCommand { get; }
        public RelayCommand OpenIconInBrowserCommand { get; }
        public RelayCommand<int> SetIconAsSummonerIconCommand { get; }

        #endregion

        private SummonerIcon _summonerIcon;

        public SummonerIconViewModel(SummonerIcon summonerIcon, string basePath)
        {
            _summonerIcon = summonerIcon;

            FullPath = basePath + ImagePath;

            CopyIconUrlCommand = new RelayCommand(CopyIconUrl);
            OpenIconInBrowserCommand = new RelayCommand(OpenIconInBrowser);
            SetIconAsSummonerIconCommand = new RelayCommand<int>(SetIconAsSummonerIcon);
        }

        private void CopyIconUrl()
        {
            Clipboard.SetText(FullPath);
        }

        private void OpenIconInBrowser()
        {
            Process.Start(FullPath);
        }

        private async void SetIconAsSummonerIcon(int id)
        {
            try
            {
                await AppState.LeagueClientApi.Summoner.SetCurrentSummonerIcon(new LolSummonerSummonerIcon(id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using IconBrowser.ValueConverters;
using LCUNet;
using LCUNet.Exceptions;
using LCUNet.Models.GameData;
using LCUNet.Models.System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace IconBrowser.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string WindowTitle
        {
            get
            {
                if (!_isConnected || _buildInfo == null)
                    return "IconBrowser";

                return $"IconBrowser - {_buildInfo.Patchline}/{_buildInfo.Branch}";
            }
        }

        public List<SummonerIconViewModel> SummonerIcons { get; set; } // Doesn't need to be a ObservableCollection

        #region Status bar

        public string LcuConnectionStatus => _isConnected ? "Connected" : "Not connected";
        public string LastLogEntry { get; set; } // TODO: Use real logger

        #endregion

        private bool _isConnected { get; set; }
        private LeagueClientApi _api = AppState.LeagueClientApi;
        private BuildInfo _buildInfo = null;

        public MainWindowViewModel()
        {
            // Try to connect to the League Client, don't wait for it to finish
            AsyncInitialize();
        }

        private async void AsyncInitialize()
        {
            _isConnected = await _api.Initialize();

            if (_isConnected)
            {
                // Get buildinfo (client version etc) 
                LastLogEntry = "Retrieving BuildInfo...";
                _buildInfo = await _api.System.GetBuildInfo();

                // Get list of all summoner icons and icon sets
                List<SummonerIcon> summonerIcons = null;
                List<SummonerIconSet> summonerIconSets = null;
                try
                {
                    LastLogEntry = "Retrieving icons...";
                    summonerIcons = await _api.GameData.GetSummonerIcons();

                    LastLogEntry = "Retrieving iconsets...";
                    summonerIconSets = await _api.GameData.GetSummonerIconSets();
                }
                catch (LeagueClientException ex)
                {
                    LastLogEntry = ex.Message;
                    MessageBox.Show(ex.Message);
                }

                if (summonerIcons != null)
                {
                    string basePath = _api.HttpClient.GetFullUrl(embedAuthDetails: true);

                    SummonerIcons = summonerIcons.Select(x => new SummonerIconViewModel(x, basePath)).OrderBy(x => x.Id).ToList();
                    // TODO: SummonerIconSets

                    LastLogEntry = $"Loaded {summonerIcons.Count} icons split over {summonerIconSets.Count} sets";
                }
            }
        }
    }
}

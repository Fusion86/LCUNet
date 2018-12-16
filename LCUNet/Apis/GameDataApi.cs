using LCUNet.Models.GameData;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCUNet.Apis
{
    public class GameDataApi : ApiBase
    {
        public override string Name => "lol-game-data";

        public GameDataApi(LeagueHttpClient client) : base(client)
        {
        }

        public async Task<List<Champion>> GetChampionSummary()
        {
            return await m_client.GetAsync<List<Champion>>(GetPluginUrl("/assets/v1/champion-summary.json"));
        }

        public async Task<List<ProfileIcon>> GetProfileIcons()
        {
            return await m_client.GetAsync<List<ProfileIcon>>(GetPluginUrl("/assets/v1/profile-icons.json"));
        }

        public async Task<List<SummonerIcon>> GetSummonerIcons()
        {
            return await m_client.GetAsync<List<SummonerIcon>>(GetPluginUrl("/assets/v1/summoner-icons.json"));
        }

        public async Task<List<SummonerIconSet>> GetSummonerIconSets()
        {
            return await m_client.GetAsync<List<SummonerIconSet>>(GetPluginUrl("/assets/v1/summoner-icon-sets.json"));
        }
    }
}

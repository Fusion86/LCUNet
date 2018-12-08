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
    }
}

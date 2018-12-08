using LCUNet.Models.ChampSelect;
using System.Threading.Tasks;

namespace LCUNet.Apis
{
    public class ChampSelectApi : ApiBase
    {
        public override string Name => "lol-champ-select";

        public ChampSelectApi(LeagueHttpClient client) : base(client)
        {
        }

        public async Task<ChampSelectSession> GetSession()
        {
            return await m_client.GetAsync<ChampSelectSession>(GetPluginUrl("/v1/session"));
        }

        public async Task<TeamBoost> GetTeamBoost()
        {
            return await m_client.GetAsync<TeamBoost>(GetPluginUrl("/v1/team-boost"));
        }
    }
}

using LCUNet.Definitions;
using LCUNet.Models.Summoner;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace LCUNet.Apis
{
    public class SummonerApi : ApiBase
    {
        public override string Name => "lol-summoner";

        public SummonerApi(LeagueHttpClient client) : base(client)
        {
        }

        public async Task<Summoner> GetCurrentSummoner()
        {
            return await m_client.GetAsync<Summoner>(GetPluginUrl("/v1/current-summoner"));
        }

        public async Task<Summoner> GetSummoner(string name)
        {
            return await m_client.GetAsync<Summoner>(GetPluginUrl("/v1/summoners?name=" + HttpUtility.UrlEncode(name)));
        }

        public async Task<bool> SetCurrentSummonerIcon(LolSummonerSummonerIcon summonerIcon)
        {
            HttpContent content = new StringContent(summonerIcon.ToJson());
            var res = await m_client.PutAsync(GetPluginUrl("/v1/current-summoner/icon"), content);
            return res.IsSuccessStatusCode;
        }
    }
}

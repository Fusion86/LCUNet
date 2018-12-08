using LCUNet.Models.System;
using System.Threading.Tasks;

namespace LCUNet.Apis
{
    public class SystemApi : ApiBase
    {
        public override string Name => "system";

        public SystemApi(LeagueHttpClient client) : base(client)
        {
        }

        public async Task<BuildInfo> GetBuildInfo()
        {
            return await m_client.GetAsync<BuildInfo>(GetPluginUrl("/v1/builds"));
        }
    }
}

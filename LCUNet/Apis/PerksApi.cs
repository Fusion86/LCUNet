﻿using LCUNet.Models.Perks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace LCUNet.Apis
{
    public class PerksApi : ApiBase
    {
        public override string Name => "lol-perks";

        public PerksApi(LeagueHttpClient client) : base(client)
        {
        }

        public async Task<List<Perk>> GetPerks()
        {
            return await m_client.GetAsync<List<Perk>>(GetPluginUrl("/v1/perks"));
        }

        public async Task<List<PerkPage>> GetPerkPages()
        {
            return await m_client.GetAsync<List<PerkPage>>(GetPluginUrl("/v1/pages"));
        }

        public async Task<PerkPage> GetPerkPage(int id)
        {
            return await m_client.GetAsync<PerkPage>(GetPluginUrl("/v1/pages/" + id));
        }

        public async Task<bool> SetPerkPage(PerkPage page)
        {
            HttpContent content = new StringContent(page.ToJson());
            var res = await m_client.PutAsync(GetPluginUrl("/v1/pages/" + page.Id), content);

            return res.IsSuccessStatusCode;
        }

        public async Task<PerkPage> GetCurrentPage()
        {
            return await m_client.GetAsync<PerkPage>(GetPluginUrl("/v1/currentpage"));
        }

        public async Task<bool> SetCurrentPage(int id)
        {
            StringContent content = new StringContent(id.ToString());

            var res = await m_client.PutAsync(GetPluginUrl("/v1/currentpage"), content);
            return res.IsSuccessStatusCode;
        }

        public async Task<List<Style>> GetStyles()
        {
            return await m_client.GetAsync<List<Style>>(GetPluginUrl("/v1/styles"));
        }
    }
}

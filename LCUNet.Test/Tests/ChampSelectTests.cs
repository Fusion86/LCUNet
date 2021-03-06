﻿using LCUNet.Exceptions;
using LCUNet.Models.ChampSelect;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace LCUNet.Test.Tests
{
    [TestClass]
    public class ChampSelectTests
    {
        private LeagueClientApi client = GlobalContext.Client;

        [TestMethod]
        public async Task GetSession()
        {

            ChampSelectSession obj = null;

            try
            {
                obj = await client.ChampSelect.GetSession();
            }
            catch (LeagueClientException ex)
            {
                if (ex.Message == "No active delegate")
                    Assert.Inconclusive("Not in Champ Select");
                else
                    throw;
            }

            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public async Task GetSessionNotInChampSelect()
        {
            LeagueClientException exception = null;

            try
            {
                var obj = await client.ChampSelect.GetSession();
            }
            catch (LeagueClientException ex)
            {
                exception = ex;
            }

            Assert.IsTrue(exception != null);
            Assert.IsTrue(exception.Message == "No active delegate");
        }

        [TestMethod]
        public async Task GetTeamBoost()
        {

            TeamBoost obj = null;

            try
            {
                obj = await client.ChampSelect.GetTeamBoost();
            }
            catch (LeagueClientException ex)
            {
                if (ex.Message == "No active delegate")
                    Assert.Inconclusive("Not in Champ Select");
                else
                    throw;
            }

            Assert.IsNotNull(obj);
        }
    }
}

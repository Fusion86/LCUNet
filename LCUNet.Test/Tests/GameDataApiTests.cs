using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace LCUNet.Test.Tests
{
    [TestClass]
    public class GameDataApiTests
    {
        private LeagueClientApi client = GlobalContext.Client;

        [TestMethod]
        public async Task GetChampionSummary()
        {
            var obj = await client.GameData.GetChampionSummary();
            Assert.IsTrue(obj.Count > 0);
        }

        [TestMethod]
        public async Task GetProfileIcons()
        {
            var obj = await client.GameData.GetProfileIcons();
            Assert.IsTrue(obj.Count > 0);
        }

        [TestMethod]
        public async Task GetSummonerIcons()
        {
            var obj = await client.GameData.GetSummonerIcons();
            Assert.IsTrue(obj.Count > 0);
        }

        [TestMethod]
        public async Task GetSummonerIconSets()
        {
            var obj = await client.GameData.GetSummonerIconSets();
            Assert.IsTrue(obj.Count > 0);
        }
    }
}

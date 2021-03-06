﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace LCUNet.Test.Tests
{
    [TestClass]
    public class AssetsApiTests
    {
        private LeagueClientApi client = GlobalContext.Client;

        [TestMethod]
        public async Task GetAsset()
        {
            var obj = await client.Assets.GetAsset("/lol-game-data/assets/v1/champion-icons/1.png");
            Assert.IsNotNull(obj);
        }
    }
}

﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace LCUNet.Test.Tests
{
    [TestClass]
    public class DataStoreApiTests
    {
        private LeagueClientApi client = GlobalContext.Client;

        [TestMethod]
        public async Task GetInstallDir()
        {
            string obj = await client.DataStore.GetInstallDir();
            Assert.IsTrue(obj.Length > 0);
        }
    }
}

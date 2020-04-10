using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Badges;

namespace Badges_Test
{
    [TestClass]
    public class Badge_Repo_Test : BadgeRepository
    {
        [TestMethod]
        public void AddBadge_ReturnTest()
        {
            Badge test = new Badge();
            bool thing = AddBadge(test);
            Assert.IsTrue(thing);
        }

        [TestMethod]
        public void LoadNewKey_Test()
        {
            Badge test = new Badge();
            LoadNewKey(test);
            bool addedtokeys = (keys.Count == 1);
            Assert.IsTrue(addedtokeys);
        }

        [TestMethod]
        public void Load_Test()
        {
            Badge test = new Badge();
            AddBadge(test);
            LoadKeys();
            bool addedtokeys = (keys.Count == 1);
            Assert.IsTrue(addedtokeys);
        }
    }
}

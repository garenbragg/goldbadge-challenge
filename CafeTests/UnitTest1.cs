using System;
using Cafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CafeTests
{
    [TestClass]
    public class UnitTest1 : MenuRepository
    {
        [TestMethod]
        public void AddToMenu_ReturnTest()
        {
            Menu test = new Menu();
            bool thing = AddToMenu(test);
            Assert.IsTrue(thing);
        }

        [TestMethod]
        public void DeleteFromMenu_Test()
        {
            Menu test = new Menu();
            bool thing = DeleteFromMenu(test);
            Assert.IsFalse(thing);
        }
    }
}

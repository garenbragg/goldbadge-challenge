using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cafe;

namespace Cafe_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddToMenu_ShouldReturnTrue()
        {
            Menu newitem = new Menu();
            bool test = AddToMenu(newitem);
            Assert.IsTrue(test);
        }
    }
}

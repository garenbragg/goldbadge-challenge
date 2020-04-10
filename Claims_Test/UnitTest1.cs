using System;
using Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Claims_Test
{
    [TestClass]
    public class UnitTest1 : ClaimsRepository
    {
        [TestMethod]
        public void ClaimAdd_Test()
        {
            Claim test = new Claim();
            bool thing = AddClaim(test);
            Assert.IsTrue(thing);
        }

        [TestMethod]
        public void ViewAll_Tests()
        {
            ViewAll();
        }

        [TestMethod]
        public void ThankU_Next_AlsoDataTest()
        {
            Data();
            Claim test = NextClaim();
            Assert.IsNotNull(test);
        }
    }
}

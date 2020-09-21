using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DogRace_Assign_sepTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DogRace_Assign_sep.Baljeet bal = new DogRace_Assign_sep.Baljeet(100,1,20);
            int result=bal.checkResult(1);
            if (result == 120)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            DogRace_Assign_sep.Sukh bal = new DogRace_Assign_sep.Sukh(100, 1, 20);
            int result = bal.checkResult(2);
            if (result ==80)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

    }
}

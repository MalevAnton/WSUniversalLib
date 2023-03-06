using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetProfityForAgeTest()
        {
            int rez = 115;

            Calculation calculation = new Calculation();

            int fak = calculation.GetProfityForAgent(1, 23, 10);

            Assert.AreEqual(rez, fak);
        }
    }
}

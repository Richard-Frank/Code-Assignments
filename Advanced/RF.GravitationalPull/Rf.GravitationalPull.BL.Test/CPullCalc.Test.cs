using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF.GravitationalPull.BL;

namespace Rf.GravitationalPull.BL.Test
{
    [TestClass]
    public class CPullCalcTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            double expected = 24706235664;
            double actual = 0;

            //CPullCalc.Calculate(100, 5.98 * Math.Pow(10, 24), 6.38 * Math.Pow(10, 6), out actual);

            //Assert.AreEqual(expected, actual);

            CPullCalc.Calculate(5.972e24, 62, 1000, out actual);

            Assert.AreEqual(expected, actual);
        }
    }
}

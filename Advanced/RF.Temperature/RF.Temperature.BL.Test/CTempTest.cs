using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF.Temperature1.BL;

namespace RF.Temperature.BL.Test
{
    [TestClass]
    public class CTempTest
    {
        //Test cases will skip breakpoints unless you are "Debugging Test"

        [TestMethod]
        public void ConvertToFahrTest()
        {
            double expected = 212;

            double actual = CTemper.ConvertToFahr(100);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertToCelsius()
        {
            double expected = 100;
            double actual;

            CTemper.ConvertToCelsius(212, out actual);

            //Has a delta of 2. It will pass the test if the result is within 2 of the actual.
            //Delta  has other variables.
            Assert.AreEqual(expected, actual, 2);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectTimer.BusinessLayer;
using System.Threading;

namespace ObjectTimer.BL.Test
{
    [TestClass]
    public class TimerTest
    {
        [TestMethod]
        public void ClockTest()
        {
            CTimer oTimer = new CTimer();

            string ExpectedTime = "00:00:05";
            string ActualTime;

            oTimer.StartClock();
            Thread.Sleep(5000);
            oTimer.StopClock();

            ActualTime = oTimer.Elapsedtime;

            Assert.AreEqual(ExpectedTime, ActualTime);

        }

        [TestMethod]
        [ExpectedException(typeof(ObjectTimer.CustomExceptions.StartException))]
        public void StartExceptionTest()
        {
            CTimer oTimer = new CTimer();

            oTimer.StartClock();
            oTimer.StartClock();

        }

        [TestMethod]
        [ExpectedException(typeof(ObjectTimer.CustomExceptions.StopException))]
        public void StopExceptionTest()
        {
            CTimer oTimer = new CTimer();

            oTimer.StopClock();

        }
    }
}

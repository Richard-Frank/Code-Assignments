using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF.VehicleTracker.BL;
namespace RF.VehicleTracker.BL.Test

{
    [TestClass]
    public class utColor
    {
        [TestMethod]
        public void LoadColorsTest()
        {
            CColorList colors = new CColorList();
            colors.Load();

            Assert.AreEqual(5, colors.Count);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Computerland.BL;
using Computerland.Interfaces;
using Computerland.PL;

namespace Computerland.BL.Test
{
    [TestClass]
    public class ComputerTest
    {
        [TestMethod]
        public void SaveAllTest()
        {


            CComputerList oSaveComputerList = new CComputerList();
            CComputerList oLoadComputerList = new CComputerList();

            // Add a computer.
            CComputer oC = new CComputer();
            oC.Id = 101;
            oC.Model = "SuperMegaCool";
            oC.Type = 1;
            oC.SerialNumber = "D5005000";
            oC.Memory = 666;
            oC.Brand = "Dull";

            oSaveComputerList.Add(oC);

            // Add a computer.
            oC = new CComputer();
            oC.Id = 404;
            oC.Model = "BadTimes!";
            oC.Type = 98;
            oC.SerialNumber = "ABC10101010101";
            oC.Memory = 777;
            oC.Brand = "Cull";

            oSaveComputerList.Add(oC);

            oSaveComputerList.SaveAll();

            oLoadComputerList.LoadAll();

            Assert.AreEqual(oSaveComputerList.Count, oLoadComputerList.Count);

        }

        [TestMethod]
        public void ComputerTypeGetDataTest()
        {
            CComputerTypeList oComputerTypes = new CComputerTypeList();

            int Expected = 3;
            int Actual = oComputerTypes.Count;

            oComputerTypes.GetData();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void ComputerTypeInsertTest()
        {
            CComputerType oCT = new CComputerType("-99", "Captain Planet?");

            bool result = oCT.Insert();

            Assert.IsTrue(result);

            oCT.Delete();
        }

        [TestMethod]
        public void ComputerTypeUpdateTest()
        {
            CComputerType oCT = new CComputerType("-50", "Testing is the best kind of -ing");

            oCT.Insert();

            oCT.Description = "New Value";
            int result = oCT.Update();

            // Works, but is not the best test.
            //Assert.IsTrue(result > 0);

            CComputerType oCT2 = new CComputerType();

            oCT2.GetDataById("-50");

            Assert.AreEqual(oCT.Description, oCT2.Description);

            oCT2.Delete();
        }

        [TestMethod]
        public void ComputerTypeDeleteTest()
        {
            CComputerType oCT = new CComputerType("-25", "Delete Test");

            oCT.Insert();

            CComputerType oCT2 = new CComputerType();

            oCT2.GetDataById("-25");

            oCT2.Delete();

            CComputerType oCT3 = new CComputerType();

            oCT3.GetDataById("-25");

            Assert.AreNotEqual(oCT2.Description, oCT3.Description);
        }

        [TestMethod]
        public void name()
        {

        }
    }
}

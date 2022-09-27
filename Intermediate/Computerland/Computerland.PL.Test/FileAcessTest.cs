using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Computerland.PL;

namespace Computerland.PL.Test
{
    [TestClass]
    public class FileAcessTest
    {
        [TestMethod]
        public void ReadTest()
        {
            string expected = "Hello Cruel World..!";
            string actual;

            actual = "Bacon";

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void WriteTest()
        {
            string expected = "Hello Cruel World..!";
            string actual;

            //CFileAcess.Write(expected);

            actual = "Bacon";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertComputerTypeTest()
        {
            CDatabase oDB = new CDatabase();
            string Insertsql = "Insert into tblComputerType select 3, 'Tablet'";

            bool result = oDB.Insert(Insertsql);


            Assert.IsTrue(result);

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using RF.Cardgame.BL;
using RF.Cardgame.PL;

namespace RF.Cardgame.BL.Test
{
    [TestClass]
    public class utAdmin
    {
        [TestMethod]
        public void LoadAdminsTest()
        {
            CAdminList admins = new CAdminList();
            admins.Load();

            Assert.AreEqual(1, admins.Count);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            CAdmin fetchAdmin = new CAdmin();
            fetchAdmin.Id = new Guid("C06FFE35-86CA-4243-9DC8-292949F2CEA0");

            fetchAdmin.LoadById();

            Assert.AreEqual(fetchAdmin.Name, "admin");

        }

        [TestMethod]
        public void InsertTest()
        {
            CAdmin admin = new CAdmin();

            admin.Name = "BL.Testadmin";
            admin.Password = "BLtest";

            admin.Insert();

            CardGameDataContext oDc = new CardGameDataContext();
            var fetchAdmin = oDc.tblAdmins.Where(p => p.Name == admin.Name).FirstOrDefault();

            Assert.IsNotNull(fetchAdmin);
        }

        [TestMethod]
        public void UpdateTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();
            var fetchAdmin = oDc.tblAdmins.Where(p => p.Name == "BL.Testadmin").FirstOrDefault();

            CAdmin admin = new CAdmin();
            admin.Id = fetchAdmin.Id;

            admin.LoadById();

            admin.Name = "BL.TestAdminUpdate";
            admin.Password = "BL.AdminUpdate";

            admin.Update();

            fetchAdmin = null;
            fetchAdmin = oDc.tblAdmins.Where(p => p.Name == "BL.TestAdminUpdate").FirstOrDefault();

            Assert.IsNotNull(fetchAdmin);
        }

        [TestMethod]
        public void DeleteTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();
            var fetchAdmin = oDc.tblAdmins.Where(p => p.Name == "BL.TestadminUpdate").FirstOrDefault();

            CAdmin admin = new CAdmin();
            admin.Id = fetchAdmin.Id;

            admin.Delete();

            var newfetch = oDc.tblAdmins.Where(p => p.Name == "BL.TestadminUpdate").FirstOrDefault();

            Assert.AreNotEqual(fetchAdmin, newfetch);
            Assert.IsNull(newfetch);
        }
    }
}


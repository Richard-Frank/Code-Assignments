using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace RF.Cardgame.PL.Test
{
    [TestClass]
    public class utAdmin
    {
        [TestMethod]
        public void SelectTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblAdmin> adminlist = (from c in oDc.tblAdmins select c).ToList();

            Assert.AreEqual(1, adminlist.Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblAdmin> Oldadmins = (from p in oDc.tblAdmins select p).ToList();

            tblAdmin newadmin = new tblAdmin();

            newadmin.Id = Guid.NewGuid();
            newadmin.Name = "PL.Testadmin";
            newadmin.Password = "PLTEST";

            oDc.tblAdmins.InsertOnSubmit(newadmin);

            oDc.SubmitChanges();

            tblAdmin admincard = (from p in oDc.tblAdmins
                                    where p.Name == "PL.Testadmin"
                                    select p).FirstOrDefault();

            List<tblAdmin> Newadmins = (from p in oDc.tblAdmins select p).ToList();

            Assert.IsNotNull(admincard);
            Assert.AreNotEqual(Oldadmins.Count, Newadmins.Count);
        }

        [TestMethod]
        public void UpdateTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            tblAdmin admin = (from p in oDc.tblAdmins
                                where p.Name == "PL.Testadmin"
                                select p).FirstOrDefault();


            admin.Name = "PL.Testadmin Updated";
            admin.Password = "PLTEST";


            oDc.SubmitChanges();

            tblAdmin updatedadmin = (from p in oDc.tblAdmins
                                       where p.Name == "PL.Testadmin Updated"
                                       select p).FirstOrDefault();

            Assert.IsNotNull(updatedadmin);
        }

        [TestMethod]
        public void DeleteTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            tblAdmin admin = (from p in oDc.tblAdmins
                                where p.Name == "PL.Testadmin Updated"
                                select p).FirstOrDefault();

            oDc.tblAdmins.DeleteOnSubmit(admin);
            oDc.SubmitChanges();

            Assert.AreEqual(1, oDc.tblAdmins.Count());
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF.VehicleTracker.PL;
using System.Linq;
using System.Collections.Generic;
using System.Data.Linq;

namespace RF.VehicleTracker.PL.Test
{
    [TestClass]
    public class utColor
    {
        //Use "Debug Tests" to use breakpoints.
        //All tests should work if you Run All.
        [TestMethod]
        public void SelectTest()
        {
            VehiclesDataContext oDc = new VehiclesDataContext();

            // Write to SQL (C# SQL / Linq)
            //Shit+Period+Enter to auto add using statement for "List".

            /*
             * //Weakly typed variable.
             * var colors = from c in oDc.tblColors select c;
            */

            //Strongly typed variable.
            List<tblColor> colors = (from c in oDc.tblColors select c).ToList();

            //Five or six depending on if you haven't deleted the test color.
            Assert.AreEqual(6, colors.Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            VehiclesDataContext oDc = new VehiclesDataContext();

            tblColor color = new tblColor();

            //Set the values.
            //Guid, calling new id method.
            color.Id = Guid.NewGuid();
            color.Description = "New Color";

            //Add the row
            oDc.tblColors.InsertOnSubmit(color);

            //Commit the changes.
            oDc.SubmitChanges();

            tblColor newcolor = (from c in oDc.tblColors
                                 where c.Description == "New Color"
                                 select c).FirstOrDefault();

            //Checks to see if color was added at all.
            Assert.IsNotNull(newcolor);
            //Or, check the color Id against the added color Id.
            Assert.AreEqual(color.Id, newcolor.Id);
            //Or, check to see if the objects are the same.
            Assert.AreSame(color, newcolor);
        }

        [TestMethod]
        public void UpdateTest()
        {
            VehiclesDataContext oDc = new VehiclesDataContext();

            tblColor color = (from c in oDc.tblColors
                                 where c.Description == "New Color"
                                 select c).FirstOrDefault();

            
           // tblModel model = (from c in oDc.tblModels
           //                   where c.Description == "Mustang"
           //                   select c).FirstOrDefault();

            // Set new values.
            color.Description = "Updated Color";
            //model.Description = "Updated Model";

            //Commit changes (Submits changes for everything above. Multiple tables allowed.)
            oDc.SubmitChanges();

            tblColor updatedcolor = (from c in oDc.tblColors
                              where c.Description == "Updated Color"
                              select c).FirstOrDefault();

            Assert.IsNotNull(updatedcolor);
        }
        [TestMethod]
        public void DeleteTest()
        {
            VehiclesDataContext oDc = new VehiclesDataContext();

            tblColor color = (from c in oDc.tblColors
                                 where c.Description == "Updated Color"
                                 select c).FirstOrDefault();

            oDc.tblColors.DeleteOnSubmit(color);
            oDc.SubmitChanges();
        }
        [TestMethod]
        public void SelectJoinTest()
        {
            VehiclesDataContext oDc = new VehiclesDataContext();

            var results = (from v in oDc.tblVehicles
                           join c in oDc.tblColors on v.ColorId equals c.Id
                           join ma in oDc.tblMakes on v.MakeId equals ma.Id
                           join mo in oDc.tblModels on v.ModelId equals mo.Id
                           orderby v.Year
                           select new
                           {
                               //You need column alias for same named columns.
                               Id = v.Id,
                               v.VIN,
                               ColorName = c.Description,
                               MakeName = ma.Description,
                               ModelName = mo.Description

                           }).ToList();

            Assert.AreEqual(1, results.Count);
        }
    }
}

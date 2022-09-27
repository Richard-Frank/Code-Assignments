using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF.VehicleTracker.PL;
using System.Linq;
using System.Collections.Generic;
using System.Data.Linq;

namespace RF.VehicleTracker.PL.Test
{
    [TestClass]
    public class utVehicle
    {

        [TestMethod]
        public void SelectTest()
        {
            VehiclesDataContext oDc = new VehiclesDataContext();

            //Strongly typed variable.
            List<tblVehicle> vehicles = (from v in oDc.tblVehicles select v).ToList();

            Assert.AreEqual(1, vehicles.Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            VehiclesDataContext oDc = new VehiclesDataContext();

            tblVehicle vehicle = new tblVehicle();

            vehicle.Id = Guid.NewGuid();

            vehicle.ColorId = oDc.tblColors.Where(p => p.Description == "VeryRed").FirstOrDefault().Id;
            vehicle.MakeId = oDc.tblMakes.Where(p => p.Description == "AMC").FirstOrDefault().Id;
            vehicle.ModelId = oDc.tblModels.Where(p => p.Description == "Cobalt").FirstOrDefault().Id;
            vehicle.VIN = "1234";
            vehicle.Year = 1995;

            //Add the row
            oDc.tblVehicles.InsertOnSubmit(vehicle);

            oDc.SubmitChanges();

            tblVehicle newVehicle = (from c in oDc.tblVehicles
                                     where c.VIN == "1234"
                                     select c).FirstOrDefault();
            Assert.IsNotNull(newVehicle);
        }

        [TestMethod]
        public void UpdateTest()
        {
            VehiclesDataContext oDc = new VehiclesDataContext();

            tblVehicle vehicle = (from c in oDc.tblVehicles
                                  where c.VIN == "1234"
                                  select c).FirstOrDefault();


            // tblModel model = (from c in oDc.tblModels
            //                   where c.Description == "Mustang"
            //                   select c).FirstOrDefault();

            // Set new values.
            vehicle.VIN = "UpdatedVIN";
            //model.Description = "Updated Model";

            //Commit changes (Submits changes for everything above. Multiple tables allowed.)
            oDc.SubmitChanges();

            tblVehicle updatedvehicle = (from c in oDc.tblVehicles
                                         where c.VIN == "UpdatedVIN"
                                         select c).FirstOrDefault();

            Assert.IsNotNull(updatedvehicle);
        }
        [TestMethod]
        public void DeleteTest()
        {
            VehiclesDataContext oDc = new VehiclesDataContext();

            tblVehicle vehicle = (from c in oDc.tblVehicles
                                  where c.VIN == "UpdatedVIN"
                                  select c).FirstOrDefault();

            oDc.tblVehicles.DeleteOnSubmit(vehicle);
            oDc.SubmitChanges();

            List<tblVehicle> vehicles = (from v in oDc.tblVehicles select v).ToList();

            Assert.AreEqual(1, vehicles.Count);
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
                               //You need column alias-es for same named columns.
                               Id = v.Id,
                               v.VIN,
                               ColorName = c.Description,
                               MakeName = ma.Description,
                               ModelName = mo.Description

                           }).ToList();

            Assert.AreEqual(1, results.Count);

        }

        [TestMethod]
        public void SelectSPTest()
        {
            //Stored procedure test.

            VehiclesDataContext oDc = new VehiclesDataContext();

            //LINQ SQL
            var results = from v in oDc.spGetVehicles()
                          select v;

            //Lambda expression
            var results2 = oDc.spGetVehicles();

            Assert.AreEqual(1, results.Count());
            Assert.AreEqual(1, results2.Count());
        }

        [TestMethod]
        public void SelectByColorSPTest()
        {
            //Stored procedure test with preamiter.

            VehiclesDataContext oDc = new VehiclesDataContext();

            //LINQ SQL
            var results = from v in oDc.spGetVehiclesByColor("VeryRed")
                          select v;

            //Lambda expression
            var results2 = oDc.spGetVehiclesByColor("VeryRed");

            Assert.AreEqual(1, results.Count());
            Assert.AreEqual(1, results2.Count());
        }
    }
}

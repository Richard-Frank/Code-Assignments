using RF.VehicleTracker.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using RF.Utilies.Exporter;

namespace RF.VehicleTracker.BL
{
    public class CVehicle
    {
        public Guid Id { get; set; }
        public Guid ColorId { get; set; }
        public Guid MakeId { get; set; }
        public Guid ModelId { get; set; }

        public string VIN { get; set; }
        public int Year { get; set; }

        public string ColorName { get; set; }
        public string MakeName { get; set; }
        public string ModelName { get; set; }

        //Default Constructor
        public CVehicle()
        {

        }
        //Custom Constructor ----------
        public CVehicle(Guid id, 
                        Guid colorid, 
                        Guid makeid, 
                        Guid modelid,
                        string vin,
                        int year)
        {
            //Assign fields to parameters
            Id = id;
            ColorId = colorid;
            MakeId = makeid;
            ModelId = modelid;
            VIN = vin;
            Year = year;
        }
        //---------------------------
        public CVehicle(
                Guid colorid,
                Guid makeid,
                Guid modelid,
                string vin,
                int year)
        {
            ColorId = colorid;
            MakeId = makeid;
            ModelId = modelid;
            VIN = vin;
            Year = year;
        }
        public CVehicle(Guid id)
        {
            Id = id;
        }
        public void LoadById()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var vehicle = oDc.tblVehicles.Where(p => p.Id == Id).FirstOrDefault();

                this.Id = vehicle.Id;
                this.ColorId = vehicle.ColorId;
                this.MakeId = vehicle.MakeId;
                this.ModelId = vehicle.ModelId;
                this.VIN = vehicle.VIN;
                this.Year = vehicle.Year;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var vehicle = oDc.tblVehicles.Where(p => p.Id == Id).FirstOrDefault();

                if (vehicle != null)
                {
                    oDc.tblVehicles.DeleteOnSubmit(vehicle);
                    oDc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var vehicle = oDc.tblVehicles.Where(p => p.Id == Id).FirstOrDefault();

                if (vehicle != null)
                {
                    vehicle.ColorId = this.ColorId;
                    vehicle.MakeId = this.MakeId;
                    vehicle.ModelId = this.ModelId;
                    vehicle.VIN = this.VIN;
                    vehicle.Year = this.Year;
                    oDc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insert()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                tblVehicle vehicle = new tblVehicle();

                vehicle.Id = Guid.NewGuid();
                vehicle.ColorId = this.ColorId;
                vehicle.MakeId = this.MakeId;
                vehicle.ModelId = this.ModelId;
                vehicle.VIN = this.VIN;
                vehicle.Year = this.Year;

                this.Id = vehicle.Id;

                oDc.tblVehicles.InsertOnSubmit(vehicle);
                oDc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public class CVehicleList : List<CVehicle>
    {
        public void Load()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var results = (from v in oDc.tblVehicles
                               join c in oDc.tblColors on v.ColorId equals c.Id
                               join ma in oDc.tblMakes on v.MakeId equals ma.Id
                               join mo in oDc.tblModels on v.ModelId equals mo.Id
                               select new
                               {
                                   v.Id, v.ColorId, v.MakeId, v.ModelId, v.Year, v.VIN,
                                   Colorname = c.Description,
                                   Makename = ma.Description,
                                   Modelname = mo.Description
                               }).ToList();

                foreach (var vehicle in results)
                {
                    CVehicle oVehicle = new CVehicle(vehicle.Id,
                                                     vehicle.ColorId,
                                                     vehicle.MakeId,
                                                     vehicle.ModelId,
                                                     vehicle.VIN,
                                                     vehicle.Year);
                    oVehicle.ColorName = vehicle.Colorname;
                    oVehicle.MakeName = vehicle.Makename;
                    oVehicle.ModelName = vehicle.Modelname;
                    Add(oVehicle);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void LoadSP()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var results = oDc.spGetVehicles();

                //Need to republish the SP, does not get descriptions.
                foreach (var vehicle in results)
                {
                    CVehicle oVehicle = new CVehicle(vehicle.Id,
                                                     vehicle.ColorId,
                                                     vehicle.MakeId,
                                                     vehicle.ModelId,
                                                     vehicle.VIN,
                                                     vehicle.Year);
                    oVehicle.ColorName = vehicle.ColorName;
                    oVehicle.MakeName = vehicle.MakeName;
                    oVehicle.ModelName = vehicle.ModelName;
                    Add(oVehicle);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void LoadByColor(string colorname)
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var results = oDc.spGetVehiclesByColor(colorname);

                //Need to republish the SP, does not get descriptions.
                foreach (var vehicle in results)
                {
                    CVehicle oVehicle = new CVehicle(vehicle.Id,
                                                     vehicle.ColorId,
                                                     vehicle.MakeId,
                                                     vehicle.ModelId,
                                                     vehicle.VIN,
                                                     vehicle.Year);
                    oVehicle.ColorName = vehicle.ColorName;
                    oVehicle.MakeName = vehicle.MakeName;
                    oVehicle.ModelName = vehicle.ModelName;
                    Add(oVehicle);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Export()
        {
            try
            {
                string[,] vehicles = new string[this.Count+1, 5];

                vehicles[0, 0] = "Color Name";
                vehicles[0, 1] = "Make Name";
                vehicles[0, 2] = "Model Name";
                vehicles[0, 3] = "VIN";
                vehicles[0, 4] = "Year";

                for (int iCnt = 1; iCnt < this.Count+1; iCnt++)
                {
                    CVehicle v = this[iCnt-1];
                    vehicles[iCnt, 0] = v.ColorName;
                    vehicles[iCnt, 1] = v.MakeName;
                    vehicles[iCnt, 2] = v.ModelName;
                    vehicles[iCnt, 3] = v.VIN;
                    vehicles[iCnt, 4] = v.Year.ToString();
                }

                CExcel.Export("Vehicles.xlsx", vehicles);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

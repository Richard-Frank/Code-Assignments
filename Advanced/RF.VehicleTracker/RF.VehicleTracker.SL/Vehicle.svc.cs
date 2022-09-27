using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.VehicleTracker.BL;

namespace RF.VehicleTracker.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Vehicle" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Vehicle.svc or Vehicle.svc.cs at the Solution Explorer and start debugging.
    public class Vehicle : IVehicle
    {
        public void Delete(Guid id)
        {
            try
            {
                new CVehicle(id).Delete();
                //return new ServiceResponce { IsError = false, ResponceId = 1, ResponceMessage = "Delete" };
            }
            catch (Exception ex)
            {

                //throw new ServiceResponce { IsError = true, ResponceId = 1, ResponceMessage = ex.Message };
            }
        }

        public CVehicle GetById(Guid id)
        {
            CVehicle vehicle = new CVehicle(id);
            vehicle.LoadById();
            return vehicle;
        }

        public CVehicleList GetVehicles()
        {
            CVehicleList vehicles = new CVehicleList();
            vehicles.Load();
            return vehicles;
        }

        public void Insert(Guid colorId, Guid makeId, Guid modelId, string vin, int year)
        {
            new CVehicle(colorId, makeId, modelId, vin, year).Insert();
        }

        public void Update(Guid id, Guid colorId, Guid makeId, Guid modelId, string vin, int year)
        {
            //CVehicle vehicle = new CVehicle(id, description);
            //vehicle.Update();
            new CVehicle(id, colorId, makeId, modelId, vin, year).Update();
        }

        public void UpdateObj(CVehicle vehicle)
        {
            vehicle.Update();
        }

        public void DeleteObj(CVehicle vehicle)
        {
            vehicle.Delete();
        }

        //public void InsertObj(CVehicle vehicle)
        //{
        //   vehicle.Insert();
        //}
    }
}

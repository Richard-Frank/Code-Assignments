using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.VehicleTracker.BL;

namespace RF.VehicleTracker.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Make" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Make.svc or Make.svc.cs at the Solution Explorer and start debugging.
    public class Make : IMake
    {
        public void Delete(Guid id)
        {
            new CMake(id).Delete();
        }

        public CMake GetById(Guid id)
        {
            CMake make = new CMake(id);
            make.LoadById();
            return make;
        }

        public CMakeList GetMakes()
        {
            CMakeList makes = new CMakeList();
            makes.Load();
            return makes;
        }

        public void Insert(string description)
        {
            new CMake(description).Insert();
        }

        public void Update(Guid id, string description)
        {
            //CMake make = new CMake(id, description);
            //make.Update();
            new CMake(id, description).Update();
        }

        public void UpdateObj(CMake make)
        {
            make.Update();
        }

        public void DeleteObj(CMake make)
        {
            make.Delete();
        }
    }
}

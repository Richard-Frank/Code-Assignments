using RF.VehicleTracker.PL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RF.VehicleTracker.BL
{
    public class CMake
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        //Default Constructor
        public CMake()
        {

        }
        //Custom Constructor
        public CMake(Guid id, string description)
        {
            //Assign fields to parameters
            Id = id;
            Description = description;
        }

        public CMake(Guid id)
        {
            //Assign fields to parameters
            Id = id;
        }

        public CMake(string description)
        {
            //Assign fields to parameters
            Description = description;
        }

        public void LoadById()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var make = oDc.tblMakes.Where(p => p.Id == Id).FirstOrDefault();

                this.Id = make.Id;
                this.Description = make.Description;
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

                var make = oDc.tblMakes.Where(p => p.Id == Id).FirstOrDefault();

                if (make != null)
                {
                    oDc.tblMakes.DeleteOnSubmit(make);
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

                var make = oDc.tblMakes.Where(p => p.Id == Id).FirstOrDefault();

                if (make != null)
                {
                    make.Description = this.Description;
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

                tblMake make = new tblMake();

                make.Id = Guid.NewGuid();
                make.Description = this.Description;

                this.Id = make.Id;

                oDc.tblMakes.InsertOnSubmit(make);
                oDc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public class CMakeList : List<CMake>
    {
        public void Load()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var results = (from c in oDc.tblMakes select c).ToList();

                foreach (var make in results)
                {
                    CMake oMake = new CMake(make.Id, make.Description);
                    Add(oMake);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}

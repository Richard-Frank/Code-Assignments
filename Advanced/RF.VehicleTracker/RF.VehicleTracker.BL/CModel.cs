using RF.VehicleTracker.PL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RF.VehicleTracker.BL
{
    public class CModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        //Default Constructor
        public CModel()
        {

        }
        //Custom Constructor
        public CModel(Guid id, string description)
        {
            //Assign fields to parameters
            Id = id;
            Description = description;
        }

        public CModel(Guid id)
        {
            //Assign fields to parameters
            Id = id;
        }

        public CModel(string description)
        {
            Description = description;
        }

        public void LoadById()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var model = oDc.tblModels.Where(p => p.Id == Id).FirstOrDefault();

                this.Id = model.Id;
                this.Description = model.Description;
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

                var model = oDc.tblModels.Where(p => p.Id == Id).FirstOrDefault();

                if (model != null)
                {
                    oDc.tblModels.DeleteOnSubmit(model);
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

                var model = oDc.tblModels.Where(p => p.Id == Id).FirstOrDefault();

                if (model != null)
                {
                    model.Description = this.Description;
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

                tblModel model = new tblModel();

                model.Id = Guid.NewGuid();
                model.Description = this.Description;

                this.Id = model.Id;

                oDc.tblModels.InsertOnSubmit(model);
                oDc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public class CModelList : List<CModel>
    {
        public void Load()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var results = (from c in oDc.tblModels select c).ToList();

                foreach (var model in results)
                {
                    CModel oModel = new CModel(model.Id, model.Description);
                    Add(oModel);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.VehicleTracker.BL;

namespace RF.VehicleTracker.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Model" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Model.svc or Model.svc.cs at the Solution Explorer and start debugging.
    public class Model : IModel
    {
        public void Delete(Guid id)
        {
            new CModel(id).Delete();
        }

        public CModel GetById(Guid id)
        {
            CModel model = new CModel(id);
            model.LoadById();
            return model;
        }

        public CModelList GetModels()
        {
            CModelList models = new CModelList();
            models.Load();
            return models;
        }

        public void Insert(string description)
        {
            new CModel(description).Insert();
        }

        public void Update(Guid id, string description)
        {
            //CModel model = new CModel(id, description);
            //model.Update();
            new CModel(id, description).Update();
        }

        public void UpdateObj(CModel model)
        {
            model.Update();
        }

        public void DeleteObj(CModel model)
        {
            model.Delete();
        }
    }
}

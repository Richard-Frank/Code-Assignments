using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.VehicleTracker.BL;

namespace RF.VehicleTracker.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Color" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Color.svc or Color.svc.cs at the Solution Explorer and start debugging.
    public class Color : IColor
    {
        public void Delete(Guid id)
        {
            try
            {
                new CColor(id).Delete();
                //return new ServiceResponse { IsError = false, ResponseId= 1, ResponseMessage = "Delete" };
            }
            catch (Exception ex)
            {
                //throw new ServiceResponse { IsError = true, ResponseId = 1, ResponseMessage = ex.Message };
            }

        }

        public CColor GetById(Guid id)
        {
            CColor color = new CColor(id);
            color.LoadById();
            return color;
        }

        public CColorList GetColors()
        {
            CColorList colors = new CColorList();
            colors.Load();
            return colors;
        }

        public void Insert(string description)
        {
            new CColor(description).Insert();
        }

        public void InsertObj(CColor color)
        {
            color.Insert();
        }


        public void Update(Guid id, string description)
        {
            new CColor(id, description).Update();
        }

        public void UpdateObj(CColor color)
        {
            color.Update();
        }

        public void DeleteObj(CColor color)
        {
            color.Delete();
        }
    }
}

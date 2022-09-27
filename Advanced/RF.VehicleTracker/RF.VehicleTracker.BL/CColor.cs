using RF.VehicleTracker.PL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RF.VehicleTracker.BL
{
    public class CColor
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        //Default Constructor
        public CColor()
        {

        }
        //Custom Constructor
        public CColor(Guid id, string description)
        {
            //Assign fields to parameters
            Id = id;
            Description = description;
        }

        public CColor(Guid id)
        {
            Id = id;
        }

        public CColor(string description)
        {
            Description = description;
        }

        public void LoadById()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var color = oDc.tblColors.Where(p => p.Id == Id).FirstOrDefault();

                this.Id = color.Id;
                this.Description = color.Description;
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

                var color = oDc.tblColors.Where(p => p.Id == Id).FirstOrDefault();

                if (color != null)
                {
                    oDc.tblColors.DeleteOnSubmit(color);
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

                var color = oDc.tblColors.Where(p => p.Id == Id).FirstOrDefault();

                if (color != null)
                {
                    color.Description = this.Description;
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

                tblColor color = new tblColor();

                color.Id = Guid.NewGuid();
                color.Description = this.Description;

                this.Id = color.Id;

                oDc.tblColors.InsertOnSubmit(color);
                oDc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public class CColorList : List<CColor>
    {
        public void Load()
        {
            try
            {
                VehiclesDataContext oDc = new VehiclesDataContext();

                var results = (from c in oDc.tblColors select c).ToList();

                foreach (var color in results)
                {
                    CColor oColor = new CColor(color.Id, color.Description);
                    Add(oColor);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}

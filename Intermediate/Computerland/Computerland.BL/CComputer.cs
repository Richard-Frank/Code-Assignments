using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computerland.PL;

namespace Computerland.BL
{
    public class CComputer
    {

        private List<CSoftware> oSoftwares;

        public List<CSoftware> Softwares
        {
            get { return oSoftwares; }
            set { oSoftwares = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private double memory;

        public double Memory
        {
            get { return memory; }
            set { memory = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string serialnumber;

        public string SerialNumber
        {
            get { return serialnumber; }
            set { serialnumber = value; }
        }

        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }


        public void GetDataById(string _id)
        {
            // Get one computer type
            try
            {
                CDatabase oDb = new CDatabase();
                string sSQL = "SELECT * FROM tblComputer where id = '" + _id + "'";

                DataTable oDT = new DataTable();

                oDT = oDb.GetData(sSQL);

                if (oDT.Rows.Count > 0)
                {
                    id = Convert.ToInt32(oDT.Rows[0]["Id"]);
                    brand = oDT.Rows[0]["Brand"].ToString();
                    memory = Convert.ToDouble(oDT.Rows[0]["Memory"]);
                    model = oDT.Rows[0]["Model"].ToString();
                    serialnumber = oDT.Rows[0]["serialnumber"].ToString();
                    type = Convert.ToInt32(oDT.Rows[0]["Type"]);
                }
                oDb = null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Insert()
        {
            try
            {
                CDatabase oDb = new CDatabase();

                string sSQL = "INSERT INTO tblComputer select " +
                                id.ToString() +
                                ", '" + brand +
                                "', " + memory.ToString() +
                                ", '" + model +
                                "', '" + serialnumber +
                                "', " + type.ToString();

                bool result = oDb.Insert(sSQL);
                oDb = null;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Update()
        {
            try
            {
                CDatabase oDb = new CDatabase();

                string sSQL = "UPDATE tblComputer SET Brand = '" + brand + "'," +
                              " Memory = " + memory.ToString() + "," +
                              " Model = '" + model + "', " +
                              " SerialNumber = '" + serialnumber + "'," +
                              " Type = " + type.ToString() +
                              " WHERE ID = " + id + "";

                int result = oDb.Update(sSQL);
                oDb = null;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public int Delete()
        {
            try
            {
                CDatabase oDb = new CDatabase();

                string sSQL = "DELETE FROM tblComputer " +
                              " WHERE ID = '" + id + "'";

                int result = oDb.Delete(sSQL);
                oDb = null;
                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public string FileRecord
        {
            get
            {
                return id.ToString() + "|" 
                    + brand + "|" 
                    + serialnumber + "|" 
                    + memory.ToString()+ "|" 
                    + type.ToString() + "|" 
                    + model;
            }
        }

        public void Populate()
        {
            oSoftwares = new List<CSoftware>();
            CSoftware oSoftware;

            switch (id)
            {
                case 1:
                    oSoftware = new CSoftware(101, "Exel");
                    oSoftwares.Add(oSoftware);

                    oSoftware = new CSoftware(222, "Wordpad");
                    oSoftwares.Add(oSoftware);
                    break;
                case 2:
                    oSoftware = new CSoftware(111, "Solitare");
                    oSoftwares.Add(oSoftware);

                    oSoftware = new CSoftware(202, "Visual Studio");
                    oSoftwares.Add(oSoftware);
                    break;
            }
        }

    }
}

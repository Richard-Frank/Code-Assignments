using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computerland.Interfaces;
using Computerland.PL;
using System.Data;

namespace Computerland.BL
{
    public class CComputerType : IComputerType
    {

        private string id;
        private string description;


        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string FileRecord
        {
            get
            {
                return ID + "|" + Description;
            }
        }


        //When making Constructors don't forget to add 'public'. Dummy.
        public CComputerType()
        {
            //Default Constructor
        }

        public CComputerType(string _id, string _description)
        {
            //Custom constructor.

            id = _id;
            description = _description;
        }



        public bool Insert()
        {
            try
            {
                CDatabase oDb = new CDatabase();
                string sSQL = "INSERT INTO tblComputerType SELECT '" + id + "', '" + description + "'";

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
                string sSQL = "UPDATE tblComputerType SET Description = '" + description + "'" +
                    " WHERE Id = '" + id + "'";

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
                string sSQL = "DELETE FROM tblComputerType" + " WHERE Id = '" + id + "'";

                int result = oDb.Delete(sSQL);

                oDb = null;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void GetDataById(string _id)
        {
            //Get one ComputerType

            try
            {
                CDatabase oDb = new CDatabase();
                string sSQL = "SELECT * FROM tblComputerType WHERE Id = '" + _id + "'";

                DataTable oDT = new DataTable();

                oDT = oDb.GetData(sSQL);

                if(oDT.Rows.Count > 0)
                {
                id = oDT.Rows[0]["Id"].ToString();
                description = oDT.Rows[0]["description"].ToString();

                }
                   oDb = null;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


 public void LoadAll()
{
 	throw new NotImplementedException();
}

 public void SaveAll()
{
 	throw new NotImplementedException();
}
}
}

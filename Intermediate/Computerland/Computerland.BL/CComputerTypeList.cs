using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computerland.PL;
using System.Data;

namespace Computerland.BL
{
    public class CComputerTypeList
    {
        //Crtl + H to replace.

        List<CComputerType> oComputerTypes;

        public List<CComputerType> ComputerTypes
        {
            get { return oComputerTypes; }
            set { oComputerTypes = value; }
        }

        //Default Constructor
        public CComputerTypeList()
        {
            oComputerTypes = new List<CComputerType>();
        }

        public int Count
        {
            get { return oComputerTypes.Count; }
        }

        public CComputerType this[int index]
        {
            get { return oComputerTypes[index]; }
        }

        public void Sort()
        {

        }

        public void Add(CComputerType oComputerType)
        {
            oComputerTypes.Add(oComputerType);
        }

        public void Remove(CComputerType oComputerType)
        {
            oComputerTypes.Remove(oComputerType);
        }

        public void GetData()
        {
            try
            {
                CDatabase oDb = new CDatabase();

                DataTable oDataTable = new DataTable();

                oDataTable = oDb.GetData("SELECT * FROM tblComputerType");

                oComputerTypes = new List<CComputerType>();

                foreach (DataRow odr in oDataTable.Rows)
                {
                    CComputerType oC = new CComputerType(odr["Id"].ToString(), odr["Description"].ToString());

                    oComputerTypes.Add(oC);
                }

                oDb = null;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


        public void LoadAll()
        {//Easier in XML.
            try
            {
                CFileAcess oFileAcess = new CFileAcess();
                // Read the whole file.
                string sContents = oFileAcess.Read();

                // Split into ComputerTypes. (Rows)
                string[] sArrayContents = sContents.Split('\r');

                // Split into ComputerType fields.
                oComputerTypes = new List<CComputerType>();

                // Loop through the ComputerTypes.
                foreach (string sRow in sArrayContents)
                {
                    //Makes sure that there is actually a ComputerType to read.
                    if (sRow.Length > 1)
                    {
                        //Split into individual ComputerType elements. (Remember to use single quotes.)
                        string[] sComputerType = sRow.Split('|');

                        CComputerType oC = new CComputerType();
                        oC.ID = sComputerType[0];
                        oC.Description = sComputerType[1];

                        // Add it to the list.
                        oComputerTypes.Add(oC);
                    }
                }




            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        public void SaveAll()
        {
            try
            {
                // A static class cannot/does not need to, be instantiated.
                //CFileAcess oFileAcess = new CFileAcess();


                foreach (CComputerType oComputerType in oComputerTypes)
                {
                    CFileAcess oFileAcess = new CFileAcess();

                    oFileAcess.Write(oComputerType.FileRecord);
                }


            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}

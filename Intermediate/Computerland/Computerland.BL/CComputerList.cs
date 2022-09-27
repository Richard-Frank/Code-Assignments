using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computerland.PL;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Data;

namespace Computerland.BL
{
    public class CComputerList
    {
        //Crtl + H to replace.

        List<CComputer> oComputers;

        public List<CComputer> Computers
        {
            get { return oComputers; }
            set { oComputers = value; }
        }

        //Default Constructor
        public CComputerList()
        {
            oComputers = new List<CComputer>();
        }

        public int Count
        {
            get { return oComputers.Count; }
        }

        public CComputer this[int index]
        {
            get { return oComputers[index]; }
        }

        public void Sort()
        {

        }


        public void GetData()
        {
            try
            {
                CDatabase oDb = new CDatabase();

                DataTable oDataTable = new DataTable();

                oDataTable = oDb.GetData("SELECT * FROM tblComputer");

                oComputers = new List<CComputer>();

                foreach (DataRow odr in oDataTable.Rows)
                {
                    CComputer oComputer = new CComputer();
                    oComputer.Id = Convert.ToInt32(odr["Id"]);
                    oComputer.Brand = odr["Brand"].ToString();
                    oComputer.Memory = Convert.ToDouble(odr["Memory"]);
                    oComputer.Model = odr["Model"].ToString();
                    oComputer.SerialNumber = odr["SerialNumber"].ToString();
                    oComputer.Type = Convert.ToInt32(odr["type"]);
                    oComputers.Add(oComputer);
                }
                oDb = null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void Populate()
        {
            oComputers = new List<CComputer>();

            // Add a computer.
            CComputer oC = new CComputer();
            oC.Id = 1;
            oC.Model = "SuperMegaCool";
            oC.Type = 1;
            oC.SerialNumber = "D5005000";
            oC.Memory = 666;
            oC.Brand = "Dull";
            oC.Populate();

            oComputers.Add(oC);

            // Add a computer.
            oC = new CComputer();
            oC.Id = 2;
            oC.Model = "BadTimes!";
            oC.Type = 98;
            oC.SerialNumber = "ABC10101010101";
            oC.Memory = 777;
            oC.Brand = "Cull";
            oC.Populate();

            oComputers.Add(oC);
        }

        public void Add(CComputer oComputer)
        {
            oComputers.Add(oComputer);
        }

        public void Remove(CComputer oComputer)
        {
            oComputers.Remove(oComputer);
        }

        public void LoadAll()
        {//Easier in XML?
            try
            {
                CFileAcess oFileAcess = new CFileAcess();

                // Read the whole file.
                string sContents = oFileAcess.Read();

                // Split into computers. (Rows)
                string[] sArrayContents = sContents.Split('\r');

                // Split into computer fields.
                oComputers = new List<CComputer>();

                // Loop through the computers.
                foreach (string sRow in sArrayContents)
                {
                    //Makes sure that there is actually a computer to read.
                    if (sRow.Length > 1)
                    {
                        //Split into individual computer elements. (Remember to use single quotes.)
                        string[] sComputer = sRow.Split('|');

                        CComputer oC = new CComputer();
                        oC.Id = Convert.ToInt32(sComputer[0]);
                        oC.Brand = sComputer[1];
                        oC.SerialNumber = sComputer[2];
                        oC.Memory = Convert.ToDouble(sComputer[3]);
                        oC.Type = Convert.ToInt32(sComputer[4]);
                        oC.Model = sComputer[5];

                        // Add it to the list.
                        oComputers.Add(oC);
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
                CFileAcess oFileAcess = new CFileAcess();
                // A static class cannot/does not need to, be instantiated.
                //CFileAcess oFileAcess = new CFileAcess();


                foreach (CComputer oComputer in oComputers)
                {
                    
                    oFileAcess.Write(oComputer.FileRecord);
                }


            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void LoadAllXML()
        {
            try
            {
                CFileAcess oFileAcess = new CFileAcess("Computers.xml");

                XmlSerializer oSerializer = new XmlSerializer(typeof(List<CComputer>));
                TextReader otr = new StreamReader("Computers.xml");

                oComputers = (List<CComputer>)oSerializer.Deserialize(otr);

                otr.Close();
                otr.Dispose();
                otr = null;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void SaveAllXML()
        {
            try
            {
                CFileAcess oFileAcess = new CFileAcess("Computers.xml");

                oFileAcess.Delete();

                XmlSerializer oSerializer = new XmlSerializer(typeof(List<CComputer>));
                TextWriter otw = new StreamWriter("Computers.xml");

                oSerializer.Serialize(otw, oComputers);


                otw.Close();
                otw.Dispose();
                otw = null;

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}

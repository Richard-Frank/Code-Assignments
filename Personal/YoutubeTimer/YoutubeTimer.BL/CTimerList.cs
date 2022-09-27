using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeTimer.BL
{
    public class CTimerList
    {
        //Crtl + H to replace.

        List<CTimer> oTimers;

        public List<CTimer> Timers
        {
            get { return oTimers; }
            set { oTimers = value; }
        }

        //Default Constructor
        public CTimerList()
        {
            oTimers = new List<CTimer>();
        }

        public int Count
        {
            get { return oTimers.Count; }
        }

        public CTimer this[int index]
        {
            get { return oTimers[index]; }
        }

        public void Sort()
        {

        }

        public void Add(CTimer oTimer)
        {
            oTimers.Add(oTimer);
        }

        public void Remove(CTimer oTimer)
        {
            oTimers.Remove(oTimer);
        }

        public int GetId()
        {
            {
                // If there are no customers in the list, ID is set to 1.
                if (oTimers.Count == 0)
                {
                    return 1;
                }
                else
                {
                    // Sets NewId to be larger than the highest current customer Id number
                    int NewId = oTimers.Max(oC => oC.Id) + 1;

                    return NewId;
                }
            }

        }

        /*
        public void GetData()
        {
            try
            {
                CDatabase oDb = new CDatabase();

                DataTable oDataTable = new DataTable();

                oDataTable = oDb.GetData("SELECT * FROM tblTimer");

                oTimers = new List<CTimer>();

                foreach (DataRow odr in oDataTable.Rows)
                {
                    CTimer oC = new CTimer(odr["Id"].ToString(), odr["Description"].ToString());

                    oTimers.Add(oC);
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

                // Split into Timers. (Rows)
                string[] sArrayContents = sContents.Split('\r');

                // Split into Timer fields.
                oTimers = new List<CTimer>();

                // Loop through the Timers.
                foreach (string sRow in sArrayContents)
                {
                    //Makes sure that there is actually a Timer to read.
                    if (sRow.Length > 1)
                    {
                        //Split into individual Timer elements. (Remember to use single quotes.)
                        string[] sTimer = sRow.Split('|');

                        CTimer oC = new CTimer();
                        oC.ID = sTimer[0];
                        oC.Description = sTimer[1];

                        // Add it to the list.
                        oTimers.Add(oC);
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


                foreach (CTimer oTimer in oTimers)
                {
                    CFileAcess oFileAcess = new CFileAcess();

                    oFileAcess.Write(oTimer.FileRecord);
                }


            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
         */
    }
}

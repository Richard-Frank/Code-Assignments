using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeidsMusic.Interfaces;
using HeidsMusic.DL;
using System.Xml.Serialization;
using System.IO;

namespace HeidsMusic.BL
{
    public class CWoodwinds : IInstruments
    {
        List<CWoodwind> oWoodwinds = new List<CWoodwind>();

        public CWoodwind Item(int viIndex)
        {
            return oWoodwinds[viIndex];
        }

        public int Count
        {
            get { return oWoodwinds.Count; }
        }

        public void Save()
        {
            try
            {
                CFile oFile = new CFile();
                oFile.Delete("Woodwinds.txt");

                foreach (CWoodwind oWoodwind in oWoodwinds)
                {
                    oWoodwind.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void SaveXML()
        {

            try
            {
                CFile oFile = new CFile("Woodwinds.xml");
                oFile.Delete("Woodwinds.xml");
                oFile.SaveXML(oWoodwinds, typeof(List<CWoodwind>));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoadXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CWoodwind>));
            TextReader textReader = new StreamReader("Woodwinds.xml");
            oWoodwinds = (List<CWoodwind>)serializer.Deserialize(textReader);
            textReader.Close();
            textReader.Dispose();
            textReader = null;
        }


        public List<CWoodwind> Woodwinds
        {
            get { return oWoodwinds; }
        }

        public void Add(CWoodwind oWoodwind)
        {
            oWoodwinds.Add(oWoodwind);
        }


    }
}

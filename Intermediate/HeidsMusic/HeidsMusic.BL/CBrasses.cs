using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeidsMusic.Interfaces;
using HeidsMusic.DL;
using System.IO;
using System.Xml.Serialization;

namespace HeidsMusic.BL
{
    public class CBrasses : IInstruments
    {
        List<CBrass> oBrasses = new List<CBrass>();

        public List<CBrass> Brasses
        {
            get { return oBrasses; }
            set { oBrasses = value; }
        }

        public void Add(CBrass oBrass)
        {
            oBrasses.Add(oBrass);
        }

        public CBrass Item(int viIndex)
        {
            return oBrasses[viIndex];
        }

        public int Count
        {
            get { return oBrasses.Count; }
        }

        public void Save()
        {
            try
            {
                CFile oFile = new CFile();
                oFile.Delete("Brass.txt");

                foreach (CBrass oBrass in oBrasses)
                {
                    oBrass.Save();
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
                CFile oFile = new CFile("Brass.xml");
                oFile.Delete("Brass.xml");
                oFile.SaveXML(oBrasses, typeof(List<CBrass>));
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoadXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CBrass>));
            TextReader textReader = new StreamReader("Brass.xml");
            oBrasses = (List<CBrass>)serializer.Deserialize(textReader);
            textReader.Close();
            textReader.Dispose();
            textReader = null;
        }


    }
}

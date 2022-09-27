using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PL
{
    public class CFileAcess
    {
        string filename;

        public CFileAcess()
        {
            filename = Properties.Settings.Default.FileName;
        }

        public CFileAcess(string _filename)
        {
            filename = _filename;
        }

        public string Read()
        {
            try
            {
                //Read the contents.
                StreamReader oSR = new StreamReader(filename);

                oSR = File.OpenText(Properties.Settings.Default.FileName);

                string sContents = oSR.ReadToEnd();

                oSR.Close();
                oSR.Dispose();
                oSR = null;

                return sContents;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void Write(string contents)
        {
            try
            {
                StreamWriter oSW = File.AppendText(filename);

                oSW.WriteLine(contents);

                oSW.Close();
                oSW.Dispose();

                oSW = null;


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
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

}

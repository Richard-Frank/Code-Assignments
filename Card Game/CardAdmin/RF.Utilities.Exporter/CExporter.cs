using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace RF.Utilities.Exporter
{
    public static class CExporter // making an excel reporting tool
    {                                               // 2d array!
        public static void Export(string filename, string[,] data) // static classes need static methods 
        {
            try
            {
                Application xlApp;
                Workbook xlWB;
                Worksheet xlWS;

                xlApp = new Application();
                // every excel app starts with a blank workbook
                xlWB = xlApp.Workbooks.Add(System.Reflection.Missing.Value);
                // every workbook has a sheet
                xlWS = (Worksheet)xlWB.Sheets["Sheet1"];

                for (int iRow = 0; iRow < data.GetLength(0); iRow++)
                {
                    for (int iCol = 0; iCol < data.GetLength(1); iCol++)
                    {
                        xlWS.Cells[iRow + 1, iCol + 1] = data[iRow, iCol];
                    }
                }

                xlWS.Columns.AutoFit();
                xlWS.UsedRange.Borders.LineStyle = XlLineStyle.xlContinuous; // puts borders on the cells that get filled
                xlApp.DisplayAlerts = false;

                // saving the excel doc
                xlWS.SaveAs(filename);

                // save as pdf
                xlWB.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF,
                                         filename.Substring(0, filename.Length - 5)); // trim off the xls
                // remember to close and quit
                xlWB.Close();
                xlApp.Quit();

                // cleanup, go from lowest level to highest level
                Marshal.ReleaseComObject(xlWS); // worksheet
                Marshal.ReleaseComObject(xlWB); // workbook
                Marshal.ReleaseComObject(xlApp); // app


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

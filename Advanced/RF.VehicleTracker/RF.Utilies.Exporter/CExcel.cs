using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace RF.Utilies.Exporter
{
    public static class CExcel
    {
        public static void Export(string filename, string[,] data)
        {
            try
            {
                Application xlApp;
                Workbook xlWB;
                Worksheet xlWS;

                xlApp = new Application();
                xlWB = xlApp.Workbooks.Add(System.Reflection.Missing.Value); //Creates an empty workbook.
                xlWS = (Worksheet)xlWB.Sheets["Sheet1"]; //Creates a basic worksheet named Sheet1;

                for (int irow = 0; irow < data.GetLength(0); irow++)
                {
                    for (int icol = 0; icol < data.GetLength(1); icol++)
                    {
                        xlWS.Cells[irow + 1, icol + 1] = data[irow, icol];
                    }
                }

                xlWS.Columns.AutoFit();
                xlWS.UsedRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                //xlWS.Cells.Borders.Weight = 1;
                xlApp.DisplayAlerts = false;

                // Save the doc as excel
                xlWS.SaveAs(filename);

                // Save as pdf
                xlWB.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF,
                                         filename.Substring(0, filename.Length - 5)); //Takes the filename, and removes the excel filetype, pdf will be added automatically.

                //Closes, very important. If it does not close, it does not show up anywhere.
                xlWB.Close();
                xlApp.Quit();

                //Close smallest to largest.
                Marshal.ReleaseComObject(xlWS); //Close sheet.
                Marshal.ReleaseComObject(xlWB); //Close book.
                Marshal.ReleaseComObject(xlApp); //Close app.
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

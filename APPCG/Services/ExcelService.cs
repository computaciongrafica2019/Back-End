using APPCG.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Excel = Microsoft.Office.Interop.Excel;



namespace APPCG.Services
{
    public  class ExcelService
    {

        public void Excel(string path, Dictionary<string,string> DictionayData)
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];


                foreach (KeyValuePair<string, string> value in DictionayData)
                {
                    int column = ExcelHelper.GetStringLetter(value.Key.Split(',').First());
                    int row = Convert.ToInt32(value.Key.Split(',').Last());

                    xlWorksheet.Cells[row, column].Value2 = value.Value;

                }

                //xlWorksheet.Cells["A3"].Value = "Hello world!";

                xlWorkbook.SaveAs(@"C:\ExcelTest\Test1.xlsx");
                xlWorkbook.Close();
                xlApp.Quit();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

    }





}

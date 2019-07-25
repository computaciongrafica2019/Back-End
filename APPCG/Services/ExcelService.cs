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
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[2];


                foreach (KeyValuePair<string, string> value in DictionayData)
                {
                    int column = ExcelHelper.GetStringLetter(value.Key.Split(',').First());
                    int row = Convert.ToInt32(value.Key.Split(',').Last());

                    xlWorksheet.Cells[row, column].Value2 = value.Value;

                }

                //xlWorksheet.Cells["A3"].Value = "Hello world!";
                xlApp.DisplayAlerts = false;

                xlWorkbook.SaveAs(path);
                xlWorkbook.Close();
                xlApp.Quit();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public double ExcelCotizacion(string path, int cQuantity, int cPrice)
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];

                var range = xlWorksheet.UsedRange;
                var rows = range.Rows.Count;

                String price;
                double total = 0;

                System.Diagnostics.Debug.WriteLine("Rows: " + rows);

                for (int i = 2; i <= rows; i++)
                {
                    var quantity = (range.Cells[i, cQuantity]).Value2;
                    price = (string)(range.Cells[i, cPrice]).Value2;

                    if (price != null)
                    {
                        price = price.Replace(",", "");
                        price = price.Replace("$", "");
                        total += System.Convert.ToInt32(quantity) * double.Parse(price, System.Globalization.CultureInfo.InvariantCulture);
                    }

                }
                total = (total * 1.2) + 25000;
                System.Diagnostics.Debug.WriteLine("Total: " + total);

                xlApp.DisplayAlerts = false;
                xlWorkbook.Close();
                xlApp.Quit();
                return total;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

    }





}

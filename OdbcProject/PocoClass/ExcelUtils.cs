using Bytescout.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpFrameWork.generic
{
    /// <summary>
    /// ExcelUtility to fetch the data from Excel
    /// </summary>
    public class ExcelUtility
    {
       static string filePath = "C:\\Users\\panth\\source\\repos\\OdbcProject\\OdbcProject\\Odbc Practise\\rmgyantra.xlsx";

        public string GetCellValue(string sheetName, int rowNumber, int cellNumber)
        {
            using (var document = new Spreadsheet())
            {
                document.LoadFromFile(filePath);
                var worksheet = document.Workbook.Worksheets.ByName(sheetName);
                var data = worksheet.Cell(rowNumber, cellNumber).Value;

                return data.ToString();
            }
        }








































        public static IEnumerable<object[]> DataEmployee()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(filePath);
            var sheet = spreadsheet.Workbook.Worksheets["EMPLOYEEID"];
            var maxrow = sheet.UsedRangeRowMax;
            var maxcol = sheet.UsedRangeColumnMax;

            for (int i = 1; i <= maxrow; i++)
            {
                string employeeId = sheet.Cell(i, 0).ToString();
                yield return new object[] { employeeId };
            }

        }

    }
}

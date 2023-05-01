using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Helpers
{
    public class ExcelReader
    {

        /// <summary>
        /// Excel Data Reader
        /// Install Nuget Package ExcelDataReader and ExcelDataReader.DataSet

        /// Steps
        /// Create Object of FileStream - Pointing to Excel File
        /// Open excel using ExcelReaderFactory
        /// Use AsDataSet().Tables[SheetName] this will return the data in table format
        /// Use rowS[rowindex][colindex] return the data from cell

        /// </summary>

        public static string file_Path = @"D:\Work\Training\Selenium\SpecFlowProject\SpecFlowProject\Data\Data.xlsx";
        public static string ReadExcelData(int rowNumber, int colNumber)
        {
            var fileStream = new FileStream(file_Path, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
            DataTable table = reader.AsDataSet().Tables["Data"];
            var data = table.Rows[rowNumber][colNumber];
            Console.WriteLine(data.ToString());
            return data.ToString();
        }
        public static string ReadExcelRow(int rowNumber, int colNumber)
        {
            var fileStream = new FileStream(file_Path, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
            DataTable table = reader.AsDataSet().Tables["Data"];
            var data = table.Rows[rowNumber][colNumber];
            return data.ToString();
        }
    }
}

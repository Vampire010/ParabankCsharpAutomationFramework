using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Parabank.TestDataAccess
{
    public class ExcelOperations
    {

        public static DataTable ExcelToDataTable(string Filename)
        {

            FileStream stream = File.Open(Filename, FileMode.Open, FileAccess.Read);

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            //Get all the Tables
            DataTableCollection table = result.Tables;

            //Store it in DataTable
            DataTable resultTable = table["DataSet"];
            return resultTable;
        }

        static List<Datacollection> datacol = new List<Datacollection>();
        public static void PopulateInCollection(string Filename)
        {
            DataTable table = ExcelToDataTable(Filename);

            for (int row = 1; row < table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    datacol.Add(dtTable);
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                string data = (from colData in datacol
                               where colData.colName == columnName
                               && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}

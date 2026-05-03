using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Data;

namespace EconomicIndicatorsApp.Implementations
{
    public class ExcelService
    {
        public DataTable ReadFirstSheet(string filePath)
        {
            var dataTable = new DataTable();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                var firstRow = true;

                foreach (var row in worksheet.RowsUsed())
                {
                    if (firstRow)
                    {

                        foreach (var cell in row.CellsUsed())
                            dataTable.Columns.Add(cell.GetString());
                        firstRow = false;
                    }
                    else
                    {
                        var dataRow = dataTable.NewRow();
                        int colIndex = 0;
                        foreach (var cell in row.CellsUsed())
                        {
                            dataRow[colIndex] = cell.GetString();
                            colIndex++;
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }

            return dataTable;
        }
    }
}

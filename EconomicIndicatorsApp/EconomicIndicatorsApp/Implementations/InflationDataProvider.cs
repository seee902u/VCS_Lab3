using System;
using System.IO;
using ClosedXML.Excel;

namespace EconomicIndicatorsApp.Implementations
{
    // Чтение исторических значений инфляции из .xlsx файла.
    public class InflationDataProvider
    {
        private readonly string _filePath;

        public InflationDataProvider(string filePath)
        {
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
        }

        // Считывает значения инфляции из ячеек B2:B17 первого листа.
        public double[] ReadInflationRates()
        {
            if (!File.Exists(_filePath))
                throw new FileNotFoundException($"Файл данных не найден: {_filePath}");

            var rates = new double[16];

            using (var workbook = new XLWorkbook(_filePath))
            {
                var sheet = workbook.Worksheet(1);

                for (int i = 0; i < 16; i++)
                {
                    var cell = sheet.Cell(i + 2, 2);
                    if (!cell.TryGetValue<double>(out double value))
                        throw new FormatException($"Некорректное значение в ячейке B{i + 2}");

                    rates[i] = value;
                }
            }

            return rates;
        }
    }
}

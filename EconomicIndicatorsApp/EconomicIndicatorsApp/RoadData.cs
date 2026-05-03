using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EconomicIndicatorsApp
{
    public class RoadData
    {
        public string Subject { get; set; }
        public int Year { get; set; }
        public double Percent { get; set; }
    }

    public static class RoadDataService
    {
        /// Загружает список данных из CSV с разделителем ';'
        /// Ожидается строка заголовка: "Субъект;Год;Процент"
        public static List<RoadData> LoadFromCsv(string filePath)
        {
            var list = new List<RoadData>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("Субъект")) continue;
                string[] parts = line.Split(';');
                if (parts.Length >= 3)
                {
                    list.Add(new RoadData
                    {
                        Subject = parts[0].Trim(),
                        Year = int.Parse(parts[1].Trim()),
                        Percent = double.Parse(parts[2].Trim(),
                            System.Globalization.CultureInfo.InvariantCulture)
                    });
                }
            }
            return list;
        }

        /// Находит субъекты с максимальным и минимальным уменьшением процента за весь период (разность последнего и первого года).
        /// Возвращает кортеж: (субъект с макс. уменьшением, значение, субъект с мин. уменьшением, значение)
        public static (string maxDecreaseSubject, double maxDecrease,
                       string minDecreaseSubject, double minDecrease) FindMinMaxDecrease(
            List<RoadData> data)
        {
            var groups = data.GroupBy(d => d.Subject);
            double maxDecrease = double.MaxValue; // будет самым отрицательным
            double minDecrease = double.MinValue; // будет самым положительным (или наименьшим по модулю)
            string maxSubj = "", minSubj = "";

            foreach (var group in groups)
            {
                var sorted = group.OrderBy(d => d.Year).ToList();
                double first = sorted.First().Percent;
                double last = sorted.Last().Percent;
                double change = last - first;

                if (change < maxDecrease)
                {
                    maxDecrease = change;
                    maxSubj = group.Key;
                }
                if (change > minDecrease)
                {
                    minDecrease = change;
                    minSubj = group.Key;
                }
            }
            return (maxSubj, maxDecrease, minSubj, minDecrease);
        }

        /// Прогнозирование методом экстраполяции по скользящей средней.
        /// Возвращает список прогнозных значений (по одному на каждый год прогноза).
        public static List<double> MovingAverageForecast(List<double> historicalValues,
            int window, int forecastHorizon)
        {
            List<double> forecast = new List<double>();
            List<double> data = new List<double>(historicalValues);
            for (int i = 0; i < forecastHorizon; i++)
            {
                double sum = 0;
                int count = 0;
                // берём window последних элементов, включая только что спрогнозированные
                for (int j = data.Count - window; j < data.Count; j++)
                {
                    if (j >= 0)
                    {
                        sum += data[j];
                        count++;
                    }
                }
                double avg = (count > 0) ? sum / count : 0;
                forecast.Add(avg);
                data.Add(avg); // добавляем прогноз в историю для следующего шага
            }
            return forecast;
        }
    }
}
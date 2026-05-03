using System;
using System.Collections.Generic;

uusing System;
using System.Collections.Generic;
using System.Linq;

namespace EconomicIndicatorsApp.Implementations
{
    // Выполнение экстраполяции на основе скользящей средней.
    public class MovingAverageForecaster
    {
        // Прогнозирование инфляции на несколько будущих периодов.
        public double[] Forecast(double[] historicalData, int periodsAhead, int windowSize = 3)
        {
            if (historicalData == null || historicalData.Length < windowSize)
                throw new ArgumentException($"Недостаточно исторических данных для окна {windowSize}");

            // Создание расширяемого списка, начиная с данных из файла
            var combined = new List<double>(historicalData);
            var forecasts = new double[periodsAhead];

            for (int step = 0; step < periodsAhead; step++)
            {
                double sum = 0;
                int startIndex = combined.Count - windowSize;
                for (int i = startIndex; i < combined.Count; i++)
                    sum += combined[i];

                double forecast = sum / windowSize;
                forecasts[step] = forecast;
                combined.Add(forecast);
            }

            return forecasts;
        }
    }
}

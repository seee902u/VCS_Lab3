using System;
using System.Linq;

namespace EconomicIndicatorsApp.Implementations
{
    // Бизнес-логика пересчёта цены с учётом инфляции.
    public static class PricePredictor
    {
        // Вычисление будущей стоимости товара через N лет.
        public static double PredictFuturePrice(double currentPrice, double[] inflationRates)
        {
            if (inflationRates == null || inflationRates.Length == 0)
                return currentPrice;

            double multiplier = inflationRates
                .Select(rate => 1 + rate / 100.0)
                .Aggregate(1.0, (acc, factor) => acc * factor);

            return Math.Round(currentPrice * multiplier, 2);
        }
    }
}

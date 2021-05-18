using System.Collections.Generic;
using HappyTravel.Money.Enums;

namespace HappyTravel.Money.Extensions
{
    public static class CurrencyExtensions
    {
        public static int GetDecimalDigitsCount(this Currencies currency) => CurrencyDecimalDigits[currency];
        
        private static readonly Dictionary<Currencies, int> CurrencyDecimalDigits = new Dictionary<Currencies, int>
        {
            {Currencies.AED, 2},
            {Currencies.EUR, 2},
            {Currencies.SAR, 2},
            {Currencies.USD, 2},
            {Currencies.CNY, 2},
            {Currencies.GBP, 2},
            {Currencies.BHD, 2}
        };
    }
}
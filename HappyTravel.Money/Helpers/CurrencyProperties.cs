using System.Collections.Generic;
using HappyTravel.Money.Enums;

namespace HappyTravel.Money.Helpers
{
    public static class CurrencyProperties
    {
        public static int GetDecimalDigitsCount(Currencies currency) => CurrencyDecimalDigits[currency];
        
        private static readonly Dictionary<Currencies, int> CurrencyDecimalDigits = new Dictionary<Currencies, int>
        {
            {Currencies.AED, 2},
            {Currencies.EUR, 2},
            {Currencies.SAR, 2},
            {Currencies.USD, 2}
        };
    }
}
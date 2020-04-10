using System;
using System.Collections.Generic;
using HappyTravel.Money.Enums;
using HappyTravel.Money.Models;

namespace HappyTravel.Money.Helpers
{
    public static class MoneyCeiler
    {
        public static MoneyAmount Ceil(MoneyAmount moneyAmount) 
            => new MoneyAmount(Ceil(moneyAmount.Amount, moneyAmount.Currency), moneyAmount.Currency);
        
        
        public static decimal Ceil(decimal target, string currency) 
            => Ceil(target, Enum.Parse<Currencies>(currency));
        
        public static decimal Ceil(decimal target, Currencies currency) 
            => Math.Round(target, CurrencyDecimalDigits[currency], MidpointRounding.AwayFromZero);
        
        
        private static readonly Dictionary<Currencies, int> CurrencyDecimalDigits = new Dictionary<Currencies, int>
        {
            {Currencies.AED, 2},
            {Currencies.EUR, 2},
            {Currencies.SAR, 2},
            {Currencies.USD, 2}
        };
    }
}
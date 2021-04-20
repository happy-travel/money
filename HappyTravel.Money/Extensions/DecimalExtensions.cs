using HappyTravel.Money.Enums;
using HappyTravel.Money.Models;

namespace HappyTravel.Money.Extensions
{
    public static class DecimalExtensions
    {
        public static MoneyAmount ToMoneyAmount(this decimal target, in Currencies targetCurrency) 
            => new(target, targetCurrency);


        public static MoneyAmount ToMoneyAmount(this decimal target, in MoneyAmount targetAmount) 
            => new(target, targetAmount.Currency);
    }
}

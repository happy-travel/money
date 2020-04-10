using HappyTravel.Money.Enums;

namespace HappyTravel.Money.Models
{
    public readonly struct MoneyAmount
    {
        public MoneyAmount(decimal amount, Currencies currency)
        {
            Amount = amount;
            Currency = currency;
        }
        
        public void Deconstruct(out decimal amount, out Currencies currency)
        {
            amount = Amount;
            currency = Currency;
        }

        public decimal Amount { get; }
        public Currencies Currency { get; }
    }
}
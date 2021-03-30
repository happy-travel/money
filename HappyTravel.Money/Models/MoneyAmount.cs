#nullable enable
using System;
using System.Text.Json.Serialization;
using HappyTravel.Money.Enums;

namespace HappyTravel.Money.Models
{
    public readonly struct MoneyAmount : IComparable, IComparable<MoneyAmount>
    {
        [JsonConstructor]
        public MoneyAmount(in decimal amount, Currencies currency)
        {
            Amount = amount;
            Currency = currency;
        }


        public static MoneyAmount operator +(in MoneyAmount a) => a;


        public static MoneyAmount operator -(in MoneyAmount a) => new MoneyAmount(-a.Amount, a.Currency);


        public static MoneyAmount operator +(in MoneyAmount a, in MoneyAmount b)
        {
            if (a.Currency != b.Currency)
                throw new ArgumentException(CurrencyMismatchError);

            return new MoneyAmount(a.Amount + b.Amount, a.Currency);
        }


        public static MoneyAmount operator -(in MoneyAmount a, in MoneyAmount b)
        {
            if (a.Currency != b.Currency)
                throw new ArgumentException(CurrencyMismatchError);

            return new MoneyAmount(a.Amount - b.Amount, a.Currency);
        }


        public static MoneyAmount operator *(in MoneyAmount a, in MoneyAmount b)
        {
            if (a.Currency != b.Currency)
                throw new ArgumentException(CurrencyMismatchError);

            return new MoneyAmount(a.Amount * b.Amount, a.Currency);
        }


        public static MoneyAmount operator /(in MoneyAmount a, in MoneyAmount b)
        {
            if (a.Currency != b.Currency)
                throw new ArgumentException(CurrencyMismatchError);

            return new MoneyAmount(a.Amount / b.Amount, a.Currency);
        }


        public static MoneyAmount operator %(in MoneyAmount a, in MoneyAmount b)
        {
            if (a.Currency != b.Currency)
                throw new ArgumentException(CurrencyMismatchError);

            return new MoneyAmount(a.Amount % b.Amount, a.Currency);
        }


        public static bool operator <(in MoneyAmount a, in MoneyAmount b)
        {
            if (a.Currency != b.Currency)
                throw new ArgumentException(CurrencyMismatchError);

            return a.Amount < b.Amount;
        }


        public static bool operator <=(in MoneyAmount a, in MoneyAmount b)
        {
            if (a.Currency != b.Currency)
                throw new ArgumentException(CurrencyMismatchError);

            return a.Amount <= b.Amount;
        }


        public static bool operator >=(in MoneyAmount a, in MoneyAmount b)
        {
            if (a.Currency != b.Currency)
                throw new ArgumentException(CurrencyMismatchError);

            return a.Amount >= b.Amount;
        }


        public static bool operator >(in MoneyAmount a, in MoneyAmount b)
        {
            if (a.Currency != b.Currency)
                throw new ArgumentException(CurrencyMismatchError);

            return a.Amount > b.Amount;
        }


        public static bool operator ==(in MoneyAmount a, in MoneyAmount b) => a.Equals(b);


        public static bool operator !=(in MoneyAmount a, in MoneyAmount b) => !a.Equals(b);


        public int CompareTo(object? obj)
            => obj is null
                ? 1
                : CompareTo((MoneyAmount) obj);


        public int CompareTo(MoneyAmount other)
        {
            if (!Currency.Equals(other.Currency))
                throw new ArgumentException(CurrencyMismatchError);

            return Amount.CompareTo(other.Amount);
        }


        public void Deconstruct(out decimal amount, out Currencies currency)
        {
            amount = Amount;
            currency = Currency;
        }


        public override bool Equals(object? obj) => obj is MoneyAmount other && Equals(in other);


        public bool Equals(in MoneyAmount other) => (Amount, Currency).Equals((other.Amount, other.Currency));


        public override int GetHashCode() => (Amount, Currency).GetHashCode();


        public decimal Amount { get; init; }
        public Currencies Currency { get; init; }


        private const string CurrencyMismatchError = "The operation may be performed only on MoneyAmounts of the same currency.";
    }
}
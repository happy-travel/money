using System;
using HappyTravel.Money.Enums;
using HappyTravel.Money.Models;
using Xunit;

namespace HappyTravel.Money.Tests.Tests
{
    public class MathOperationTests
    {
        [Fact]
        void Math_operations_with_different_currencies_should_be_failed()
        {
            var moneyAmount1 = new MoneyAmount(100, Currencies.USD);
            var moneyAmount2 = new MoneyAmount(100, Currencies.AED);

            Assert.Throws<ArgumentException>(() => moneyAmount1 + moneyAmount2);
            Assert.Throws<ArgumentException>(() => moneyAmount1 - moneyAmount2);
            Assert.Throws<ArgumentException>(() => moneyAmount1 * moneyAmount2);
            Assert.Throws<ArgumentException>(() => moneyAmount1 / moneyAmount2);
            Assert.Throws<ArgumentException>(() => moneyAmount1 % moneyAmount2);
        }


        [Fact]
        void Math_operations_should_be_equal_result()
        {
            var currency = Currencies.USD;
            var moneyAmount1 = new MoneyAmount(100, currency);
            var moneyAmount2 = new MoneyAmount(200, currency);
            
            Assert.True(new MoneyAmount(moneyAmount1.Amount + moneyAmount2.Amount, currency) == moneyAmount1 + moneyAmount2);
            Assert.True(new MoneyAmount(moneyAmount1.Amount - moneyAmount2.Amount, currency) == moneyAmount1 - moneyAmount2);
            Assert.True(new MoneyAmount(moneyAmount1.Amount * moneyAmount2.Amount, currency) == moneyAmount1 * moneyAmount2);
            Assert.True(new MoneyAmount(moneyAmount1.Amount / moneyAmount2.Amount, currency) == moneyAmount1 / moneyAmount2);
            Assert.True(new MoneyAmount(moneyAmount1.Amount % moneyAmount2.Amount, currency) == moneyAmount1 % moneyAmount2);
        }
    }
}
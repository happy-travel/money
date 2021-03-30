using HappyTravel.Money.Enums;
using HappyTravel.Money.Models;
using Xunit;

namespace HappyTravel.Money.Tests.Tests
{
    public class CompareTests
    {
        [Fact]
        void Same_amount_and_currency_should_be_equal()
        {
            var moneyAmount1 = new MoneyAmount(100, Currencies.USD);
            var moneyAmount2 = new MoneyAmount(100, Currencies.USD);
            
            Assert.True(moneyAmount1.Equals(moneyAmount2));
            Assert.True(moneyAmount1 == moneyAmount2);
        }
        
        
        [Fact]
        void Different_amount_should_be_not_equal()
        {
            var moneyAmount1 = new MoneyAmount(100, Currencies.USD);
            var moneyAmount2 = new MoneyAmount(200, Currencies.USD);

            Assert.False(moneyAmount1.Equals(moneyAmount2));
            Assert.False(moneyAmount1 == moneyAmount2);
        }
        
        
        [Fact]
        void Different_currencies_should_be_not_equal()
        {
            var moneyAmount1 = new MoneyAmount(100, Currencies.USD);
            var moneyAmount2 = new MoneyAmount(100, Currencies.AED);

            Assert.False(moneyAmount1.Equals(moneyAmount2));
            Assert.False(moneyAmount1 == moneyAmount2);
        }


        [Fact]
        void First_amount_should_be_greater_than_second()
        {
            var moneyAmount1 = new MoneyAmount(200, Currencies.USD);
            var moneyAmount2 = new MoneyAmount(100, Currencies.USD);
            
            Assert.True(moneyAmount1 > moneyAmount2);
            Assert.True(moneyAmount2 < moneyAmount1);
        }
    }
}
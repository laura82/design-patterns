using DecoratorPattern;
using System.Collections.Generic;
using Xunit;

namespace DecoratorPatternTests
{
    public class CoffeeBuilderTests
    {
        [Fact]
        public void Black_Coffee_Is_Created_Correctly()
        {
            var expectedResult = new Coffee("Black", new List<Milk>(), new List<Sugar>());
            var actualResult = new CoffeeBuilder().SetBlackCoffee().Build();

            Assert.Equal(expectedResult.ToString(), actualResult.ToString());
        }

        [Fact]
        public void Americano_Coffee_Is_Created_Correctly()
        {
            var expectedResult = new Coffee("Americano", new List<Milk>() { new Milk(0.5) }, new List<Sugar>());
            var actualResult = new CoffeeBuilder().SetAmericanoCoffee().Build();

            Assert.Equal(expectedResult.ToString(), actualResult.ToString());
        }

        [Fact]
        public void Cubano_Coffee_Is_Created_Correctly()
        {
            var expectedResult = new Coffee("Cubano", new List<Milk>(), new List<Sugar>() { new Sugar("Brown") });
            var actualResult = new CoffeeBuilder().SetCubanoCoffee().Build();

            Assert.Equal(expectedResult.ToString(), actualResult.ToString());
        }

        [Fact]
        public void Extra_Sugar_Is_Added_Correctly()
        {
            var expectedResult = new Coffee("Black", new List<Milk>(), new List<Sugar>() { new Sugar("Regular") });
            var actualResult = new CoffeeBuilder().SetBlackCoffee().WithSugar("Regular").Build();

            Assert.Equal(expectedResult.ToString(), actualResult.ToString());
        }

        [Fact]
        public void Extra_Milk_Is_Added_Correctly()
        {
            var expectedResult = new Coffee("Americano", new List<Milk>() { new Milk(0.5) }, new List<Sugar>());
            var actualResult = new CoffeeBuilder().SetAmericanoCoffee().WithMilk(0.5).Build();

            Assert.Equal(expectedResult.ToString(), actualResult.ToString());
        }
    }
}

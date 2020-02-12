using System;
using Xunit;
using LoggingKata;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            //Arrange
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");
            //Assert
            Assert.NotNull(actual);
            // TODO: Complete Something, if anything
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...")]
        public void ShouldParse(string str)
        {
            //Arrange
            var myTaco = new TacoParser();
            //Act
            var test = myTaco.Parse(str);
            // TODO: Complete Should Parse
            Assert.IsType<TacoBell>(test);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            // TODO: Complete Should Fail Parse
            //Arrange
            var tacoParser = new TacoParser();
            //Act
            var result = tacoParser.Parse(str);
            //Assert
            Assert.Equal(null, result);
        }
    }
}

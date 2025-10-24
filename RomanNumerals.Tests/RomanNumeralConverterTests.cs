using Xunit;

namespace RomanNumerals.Tests
{
    public class RomanNumeralConverterTests
    {
        private readonly RomanNumeralConverter _converter;

        public RomanNumeralConverterTests()
        {
            _converter = new RomanNumeralConverter();
        }

        [Fact]
        public void TestRunnerWorks()
        {
            Assert.True(true);
        }
    }
}
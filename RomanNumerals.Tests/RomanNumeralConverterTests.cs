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

        [Fact]
        public void RejectsNegativeNumbers()
        {
            int negativeNumber = -1;

            var exception = Assert.Throws<ArgumentOutOfRangeException>(
                () => _converter.Convert(negativeNumber));
            
            Assert.Contains("must be between 1 and 3000", exception.Message);
        }
    }
}
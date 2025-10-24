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


        [Fact]
        public void RejectsZero()
        {
            int zero = 0;

            var exception = Assert.Throws<ArgumentOutOfRangeException>(
                () => _converter.Convert(zero));

            Assert.Contains("must be between 1 and 3000", exception.Message);
        }


        [Fact]
        public void RejectsNumbersAboveMaximum()
        {
            int tooLarge = 3001;

            var exception = Assert.Throws<ArgumentOutOfRangeException>(
                () => _converter.Convert(tooLarge));

            Assert.Contains("must be between 1 and 3000", exception.Message);
        }

        [Fact]
        public void Converts1ToI()
        {
            string result = _converter.Convert(1);

            Assert.Equal("I", result);
        }


        [Fact]
        public void Converts5ToV()
        {
            string result = _converter.Convert(5);

            Assert.Equal("V", result);
        }

        [Fact]
        public void Converts2TOII()
        {
            string result = _converter.Convert(2);

            Assert.Equal("II", result);
        }

        [Fact]
        public void Converts10ToX()
        {
            string result = _converter.Convert(10);

            Assert.Equal("X", result);
        }

        [Fact]
        public void Converts50ToL()
        {
            string result = _converter.Convert(50);

            Assert.Equal("L", result);
        }

        [Fact]
        public void Converts100ToC()
        {
            string result = _converter.Convert(100);

            Assert.Equal("C", result);
        }


        [Fact]
        public void Converts500ToD()
        {
            string result = _converter.Convert(500);

            Assert.Equal("D", result);
        }


        
        [Fact]
        public void Converts1000ToM()
        {
            string result = _converter.Convert(1000);

            Assert.Equal("M", result);
        }
        
        
    }
}
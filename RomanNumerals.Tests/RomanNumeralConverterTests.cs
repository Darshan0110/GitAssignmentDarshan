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
        public void Converts2ToII()
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

        [Fact]
        public void Converts3ToIII()
        {
            string result = _converter.Convert(3);
            Assert.Equal("III", result);
        }

        [Fact]
        public void Converts30ToXXX()
        {
            string result = _converter.Convert(30);
            Assert.Equal("XXX", result);
        }

        [Fact]
        public void Converts300ToCCC()
        {
            string result = _converter.Convert(300);
            Assert.Equal("CCC", result);
        }

        [Fact]
        public void Converts4ToIV()
        {
            string result = _converter.Convert(4);
            Assert.Equal("IV", result);
        }

        [Fact]
        public void Converts9ToIX()
        {
            string result = _converter.Convert(9);
            Assert.Equal("IX", result);
        }

        [Fact]
        public void Converts40ToXL()
        {
            string result = _converter.Convert(40);
            Assert.Equal("XL", result);
        }

        [Fact]
        public void Converts90ToXC()
        {
            string result = _converter.Convert(90);
            Assert.Equal("XC", result);
        }

        [Fact]
        public void Converts400ToCD()
        {
            string result = _converter.Convert(400);
            Assert.Equal("CD", result);
        }

        [Fact]
        public void Converts900ToCM()
        {
            string result = _converter.Convert(900);
            Assert.Equal("CM", result);
        }

        [Fact]
        public void Converts1984ToMCMLXXXIV()
        {
            string result = _converter.Convert(1984);
            Assert.Equal("MCMLXXXIV", result);
        }

        [Fact]
        public void Converts1900ToMCM()
        {
            string result = _converter.Convert(1900);
            Assert.Equal("MCM", result);
        }

        [Fact]
        public void Converts444ToCDXLIV()
        {
            string result = _converter.Convert(444);
            Assert.Equal("CDXLIV", result);
        }

        [Fact]
        public void Converts1944ToMCMXLIV()
        {
            string result = _converter.Convert(1944);
            Assert.Equal("MCMXLIV", result);
        }

        [Fact]
        public void Converts1666ToMDCLXVI()
        {
            string result = _converter.Convert(1666);
            Assert.Equal("MDCLXVI", result);
        }

        [Fact]
        public void Converts99ToXCIX()
        {
            string result = _converter.Convert(99);
            Assert.Equal("XCIX", result);
        }

        [Fact]
        public void Converts999ToCMXCIX()
        {
            string result = _converter.Convert(999);
            Assert.Equal("CMXCIX", result);
        }

        [Fact]
        public void Converts2024ToMMXXIV()
        {
            string result = _converter.Convert(2024);
            Assert.Equal("MMXXIV", result);
        }

        [Fact]
        public void Converts3000ToMMM()
        {
            string result = _converter.Convert(3000);
            Assert.Equal("MMM", result);
        }

        [Fact]
        public void Converts2999ToMMCMXCIX()
        {
            string result = _converter.Convert(2999);
            Assert.Equal("MMCMXCIX", result);
        }

        [Fact]
        public void Converts49ToXLIX()
        {
            string result = _converter.Convert(49);
            Assert.Equal("XLIX", result);
        }

        [Fact]
        public void Converts1999ToMCMXCIX()
        {
            string result = _converter.Convert(1999);
            Assert.Equal("MCMXCIX", result);
        }

        [Fact]
        public void ResultIsNeverEmptyForValidInput()
        {
            string result = _converter.Convert(1);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void Converts8ToVIII_BasicConstruction()
        {
            string result = _converter.Convert(8);
            Assert.Equal("VIII", result);
        }

        [Fact]
        public void Converts3ToIII_NoMoreThanThreeSymbols()
        {
            string result = _converter.Convert(3);
            Assert.Equal("III", result);
            Assert.DoesNotContain("IIII", result);
        }

        [Fact]
        public void Converts4ToIV_NotIIII()
        {
            string result = _converter.Convert(4);
            Assert.Equal("IV", result);
            Assert.DoesNotContain("IIII", result);
        }

        [Fact]
        public void Converts8ToVIII_AdditiveConstruction()
        {
            string result = _converter.Convert(8);
            Assert.Equal("VIII", result);
            Assert.StartsWith("V", result);
            Assert.EndsWith("III", result);
        }

        [Fact]
        public void Converts6ToVI_AdditiveConstruction()
        {
            string result = _converter.Convert(6);
            Assert.Equal("VI", result);
        }

        [Fact]
        public void Converts15ToXV_AdditiveConstruction()
        {
            string result = _converter.Convert(15);
            Assert.Equal("XV", result);
        }

        [Fact]
        public void NoSymbolRepeatsMoreThanThreeTimes_III()
        {
            string result = _converter.Convert(3);
            Assert.Equal("III", result);
        }

        [Fact]
        public void NoSymbolRepeatsMoreThanThreeTimes_IV_NotIIII()
        {
            string result = _converter.Convert(4);
            Assert.Equal("IV", result);
            Assert.DoesNotContain("IIII", result);
        }

        [Fact]
        public void NoSymbolRepeatsMoreThanThreeTimes_XXX()
        {
            string result = _converter.Convert(30);
            Assert.Equal("XXX", result);
        }

        [Fact]
        public void NoSymbolRepeatsMoreThanThreeTimes_XL_NotXXXX()
        {
            string result = _converter.Convert(40);
            Assert.Equal("XL", result);
            Assert.DoesNotContain("XXXX", result);
        }

        [Fact]
        public void OrderOfMagnitude_MCM_Is1900()
        {
            string result = _converter.Convert(1900);
            Assert.Equal("MCM", result);
            Assert.StartsWith("M", result);
            Assert.Contains("CM", result);
        }

        [Fact]
        public void OrderOfMagnitude_HighestToLowest()
        {
            string result = _converter.Convert(1666);
            Assert.Equal("MDCLXVI", result);
            int posM = result.IndexOf('M');
            int posD = result.IndexOf('D');
            int posC = result.IndexOf('C');
            int posL = result.IndexOf('L');
            int posX = result.IndexOf('X');
            int posV = result.IndexOf('V');
            int posI = result.IndexOf('I');
            
            Assert.True(posM < posD);
            Assert.True(posD < posC);
            Assert.True(posC < posL);
            Assert.True(posL < posX);
            Assert.True(posX < posV);
            Assert.True(posV < posI);
        }

        [Fact]
        public void CombiningRules_MCMLXXXIV_Is1984()
        {
            string result = _converter.Convert(1984);
            Assert.Equal("MCMLXXXIV", result);
            Assert.Contains("M", result);
            Assert.Contains("CM", result);
            Assert.Contains("L", result);
            Assert.Contains("XXX", result);
            Assert.Contains("IV", result);
        }

        [Fact]
        public void CombiningRules_AdditiveAndSubtractive()
        {
            string result = _converter.Convert(1984);
            Assert.Equal("MCMLXXXIV", result);
        }
    }
}
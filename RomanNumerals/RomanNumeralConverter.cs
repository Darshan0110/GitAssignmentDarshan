namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        private const int MinimumValue = 1;
        private const int MaximumValue = 3000;

        private static readonly (int Value, string Symbol)[] RomanNumeralMappings = new[]
        {
            (500, "D"),
            (100, "C"),
            (50, "L"),
            (10, "X"),
            (5, "V"),
            (1, "I")
            
        };

        public string Convert(int number)
        {
            if (IsOutsideValidRange(number))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(number),
                    $"Number must be between {MinimumValue} and {MaximumValue} inclusive.");
            }

            return BuildRomanNumeral(number);
        }

        private bool IsOutsideValidRange(int number)
        {
            return number < MinimumValue || number > MaximumValue;
        }

        private string BuildRomanNumeral(int number)
        {
            string result = "";

            foreach (var (value, symbol) in RomanNumeralMappings)
            {
                while (number >= value)
                {
                    result += symbol;
                    number -= value;
                }
            }

            return result;
        }
    }
}
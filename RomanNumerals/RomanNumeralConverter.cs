namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        private const int MinimumValue = 1;
        private const int MaximumValue = 3000;

        public string Convert(int number)
        {
            if (IsOutsideValidRange(number))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(number),
                    $"Number must be between {MinimumValue} and {MaximumValue} inclusive.");
            }

            return "";
        }

        private bool IsOutsideValidRange(int number)
        {
            return number < MinimumValue || number > MaximumValue;
        }
    }
}
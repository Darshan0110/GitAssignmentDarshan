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

            if (number == 5)
            {
                return "V";
            }

            if (number == 1)
            {
                return "I";
            }

            return "";
        }            
        

        private bool IsOutsideValidRange(int number)
        {
            return number < MinimumValue || number > MaximumValue;
        }
        
    }
}
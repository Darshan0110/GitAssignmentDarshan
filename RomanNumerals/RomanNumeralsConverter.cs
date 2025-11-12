using System;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        public string Convert(int number)
        {
            if (number < 1 || number > 3000)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(number),
                    "Number must be between 1 and 3000 inclusive.");
            }
            
            return "";
        }
    }
}
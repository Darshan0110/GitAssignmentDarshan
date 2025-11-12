using System;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {

        private static readonly string[] Ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        
        public string Convert(int number)
        {
            if (number < 1 || number > 3000)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(number),
                    "Number must be between 1 and 3000 inclusive.");
            }

            
            return Ones[number % 10];
        }
    }
}
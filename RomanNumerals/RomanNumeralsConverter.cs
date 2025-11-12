using System;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {

        private static readonly string[] Tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private static readonly string[] Ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        
        public string Convert(int number)
        {
            if (number < 1 || number > 3000)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(number),
                    "Number must be between 1 and 3000 inclusive.");
            }

            
            return Tens[(number / 10) % 10] + Ones[number % 10];
        }
    }
}
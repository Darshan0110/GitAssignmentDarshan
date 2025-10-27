using RomanNumerals;

var converter = new RomanNumeralConverter();

Console.WriteLine("=== Roman Numeral Converter ===");
Console.WriteLine("Valid range: 1 to 3000");
Console.WriteLine("Type 'exit' to quit\n");

while (true)
{
    Console.Write("Enter a number: ");
    string? input = Console.ReadLine();

    if (input?.ToLower() == "exit")
    {
        break;
    }

    if (int.TryParse(input, out int number))
    {
        try
        {
            string roman = converter.Convert(number);
            Console.WriteLine($"✓ {number} = {roman}\n");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"✗ Error: {ex.Message}\n");
        }
    }
    else
    {
        Console.WriteLine("✗ Please enter a valid number\n");
    }
}

Console.WriteLine("Goodbye!");
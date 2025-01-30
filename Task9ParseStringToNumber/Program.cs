class ParseStringToNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to convert to an integer:");
        string input = Console.ReadLine();

        int result;
        bool isSuccessful = TryParseStringToInt(input, out result);

        if (isSuccessful)
        {
            Console.WriteLine($"Conversion successful! The integer value is: {result}");
        }
        else
        {
            Console.WriteLine("Conversion failed. Returning 0.");
            Console.WriteLine($"The integer value is: {result}");
        }
    }

    static bool TryParseStringToInt(string str, out int number)
    {
        if (int.TryParse(str, out number))
        {
            return true;
        }
        else
        {
            number = 0;
            return false;
        }
    }
}
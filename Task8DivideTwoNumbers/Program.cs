class DivideTwoNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number (dividend):");
        int dividend = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number (divisor):");
        int divisor = int.Parse(Console.ReadLine());

        int quotient, remainder;
        DivideNumbers(dividend, divisor, out quotient, out remainder);

        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Remainder: {remainder}");
    }

    static void DivideNumbers(int dividend, int divisor, out int quotient, out int remainder)
    {
        quotient = dividend / divisor;
        remainder = dividend % divisor;
    }
}
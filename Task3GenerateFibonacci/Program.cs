
public class GenerateFibonacci
{
    public static List<int> GenerateFibonacciSequence(int numberToGenerate)
    {
        List<int> fibonacci = new List<int>();
        
        if (numberToGenerate <= 0)
        {
            return fibonacci;
        }
        
        fibonacci.Add(0);
        
        if (numberToGenerate == 1)
        {
            return fibonacci;
        }
        
        fibonacci.Add(1);
        
        for (int i = 2; i < numberToGenerate; i++)
        {
            fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
        }
        
        return fibonacci;
    }

    public static void Main()
    {
        int numberToGenerate = -1;
        Console.WriteLine("Enter the number of Fibonacci numbers to generate:");
        
        while (numberToGenerate < 0)
        {

            if (int.TryParse(Console.ReadLine(), out numberToGenerate) && numberToGenerate >= 0)
            {
                List<int> fibonacciSequence = GenerateFibonacciSequence(numberToGenerate);
                Console.WriteLine("Fibonacci Sequence: " + string.Join(", ", fibonacciSequence));
            }
            else
            {
                Console.WriteLine("Please enter a valid non-negative integer.");
                numberToGenerate = -1; 
            }
        }
    }
}
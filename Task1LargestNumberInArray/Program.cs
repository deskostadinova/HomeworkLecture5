
public class Task1LargestNumberInArray
{
    static int FindLargestNumber(int[] arrayOfNumbers)
    {
        int max = arrayOfNumbers[0];

        for (int i = 1; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] > max)
            {
                max = arrayOfNumbers[i];
            }
        }
        return max;
    }

    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by spaces:");
        string userInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("The array is empty.");
        }
        else
        {
            var parsedNumbers = userInput.Split()
                .Where(x => int.TryParse(x, out _))
                .Select(int.Parse)
                .ToArray();
                
            if (parsedNumbers.Length == 0)
            {
                Console.WriteLine("No valid integers were entered.");
            }
            else
            {
                Console.WriteLine("The largest number is: " + FindLargestNumber(parsedNumbers));
            }
        }
    }
}
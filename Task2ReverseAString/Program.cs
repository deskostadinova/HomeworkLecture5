

public class Task2ReverseAString
{
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static void Main()
    {
        Console.WriteLine("Enter a string to reverse:");
        string userInput = Console.ReadLine();
        string reversedString = ReverseString(userInput);
        Console.WriteLine("Reversed string: " + reversedString);
    }
}
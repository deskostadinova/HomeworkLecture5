public class SwapNumbers
{
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Before swap: x = " + x + ", y = " + y);

        Swap(ref x, ref y);

        Console.WriteLine("After swap: x = " + x + ", y = " + y);
    }
}
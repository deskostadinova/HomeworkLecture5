class UpdateArrayElements
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("Enter the multiplication factor:");
        int factor = int.Parse(Console.ReadLine());

        MultiplyArrayElements(ref arr, factor);

        Console.WriteLine("Array elements after multiplication:");
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    static void MultiplyArrayElements(ref int[] array, int factor)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] *= factor;
        }
    }
}
public class SortArray
{
    public static void SortAscending(int[] array)
    {
        int arrayLength = array.Length;
        for (int i = 0; i < arrayLength - 1; i++)
        {
            for (int j = 0; j < arrayLength - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static void Main()
    {
        Console.WriteLine("Enter the elements of the array, separated by spaces:");
        string input = Console.ReadLine();
        int[] array = input.Split(' ').Select(int.Parse).ToArray();
        
        Console.WriteLine("Original array: " + string.Join(", ", array));

        SortAscending(array);

        Console.WriteLine("Sorted array: " + string.Join(", ", array));
    }
}
﻿
class Task1LargestNumberInArray {
    static int Largest(int[] arr) {
        int max = arr[0];
        
        for (int i = 1; i < arr.Count(); i++)
            if (arr[i] > max)
                max = arr[i];
        return max;
        
    }

    static void Main() {
        Console.WriteLine("Enter an array of integers, separated by spaces:");
        string input = Console.ReadLine();
        
        int[] arr = Array.ConvertAll(input.Split(' '), int.Parse);
        
        if (arr.Length == 0)
        {
            Console.WriteLine("The array is empty.");
        }
        else
        {
            Console.WriteLine(Largest(arr));
        }
    }
}


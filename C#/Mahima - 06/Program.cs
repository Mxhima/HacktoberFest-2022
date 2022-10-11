using System;

public class Example
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        int sum = 0;
        foreach (int item in array)
        {
            sum += item;
        }

        Console.WriteLine(sum);
    }
}
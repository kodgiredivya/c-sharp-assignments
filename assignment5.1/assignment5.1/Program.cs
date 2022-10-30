using System;
public class Exercise1
{
    public static void Main()
    {
        int[] arr = new int[5];
        int i;
        Console.Write("\n\nRead and Print elements of an array:\n");
        Console.Write("-----------------------------------------\n");

        Console.Write("Input 10 elements in the array :\n");
        for (i = 0; i < 5; i++)
        {
            Console.Write("element - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nElements in array are: ");
        for (i = 0; i < 5; i++)
        {
            Console.Write("{0}  ", arr[i]);
        }
        Console.Write("\n");
        Array.Sort(arr);
        Console.WriteLine("Sorted List");
        foreach (int res in arr)
        {
            Console.Write(" "+res);
        }
        Console.WriteLine();
        Array.Reverse(arr);
        Console.Write("Reversed Array: ");
        foreach (int resu in arr)
        {
            Console.Write(resu + " ");
        }

        Array.Clear(arr, 0, arr.Length);
        Console.WriteLine("Array (After using Clear):");
        foreach (int val in arr)
        {
            Console.WriteLine(val);
        }
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr1 = new int[n];
        for (int y = 0; y < n; y++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] arr2 = new int[n];
        Console.WriteLine("Integer array after sort");
        Array.Sort(arr1);
        foreach (int element in arr1)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine("Integer array after copy");
        arr1.CopyTo(arr2, 1);
        foreach (int element in arr2)
        {
            Console.Write(element + " ");
        }
        Array.Reverse(arr);
        foreach (int element in arr1)
        {
            Console.Write(element + " ");
        }
        Array.Clear(arr1, 1, 3);
        foreach (int element in arr1)
        {
            Console.Write(element + " ");
        }
        Console.ReadKey();
    }
}
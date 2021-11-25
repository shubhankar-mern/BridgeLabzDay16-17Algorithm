using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "yuvraj", "rohit", "virat", "rahul", "mahendra", "aakash" };
            int n = arr.Length, i, j;
            string val = "";
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j].CompareTo(val) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = val;
            }
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

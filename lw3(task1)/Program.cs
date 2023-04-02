using System;

namespace ConsoleApplication
{
    class Program
    {
        static void PrintReverse(ref int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--) Console.WriteLine(arr[i]);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            PrintReverse(ref arr);
        }

    }
}
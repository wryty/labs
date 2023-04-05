using System;

namespace ConsoleApplication
{
    class Program
    {
        static int[] MakeReverse(int[] arr) => arr.Reverse().ToArray<int>();
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int[] newarr = MakeReverse(arr);
            foreach (int i in newarr) Console.WriteLine(i);

        }

    }
}
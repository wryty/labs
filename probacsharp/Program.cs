using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello     ";
            Console.WriteLine(libs.Class1.RTrim(str));
            string str1 = "     hello";
            Console.WriteLine(libs.Class1.LTrim(str1));
            string str2 = "     hello      ";
            Console.WriteLine(libs.Class1.Trim(str2));
        }

    }
}
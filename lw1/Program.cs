using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите значение переменной и нажмите Enter: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a % 3 == 0) && (a % 5 == 0)) {
                Console.WriteLine("fizzbuzz");
            }
            else if (a % 3 == 0) {
                Console.WriteLine("fizz");
            }
            else if (a % 5 == 0) {
                Console.WriteLine("buzz");
            }
        }
    }
}
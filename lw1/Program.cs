using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов последовательности и нажмите Enter: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] b = new double[n];
            Console.WriteLine("Введите число, с которым мы будем сравнивать элементы последовательности и нажмите Enter: ");
            double p = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " элемент последовательности");
                b[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (b[i] > p)
                {
                    sum += b[i];
                }
            }
            Console.WriteLine("Сумма элементов, удовлетворяющих условию: " + sum);

        }
    }
}
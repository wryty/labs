using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double[] b = new double[n];
            double p = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++) {
                b[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < n; i++) {
                if (b[i] > p) {
                    sum+=b[i];
                }
            }
            Console.WriteLine("Сумма: " + sum);
            

            





            
        } 
    }
}
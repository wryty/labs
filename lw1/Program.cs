using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = {  {1,2,3},
                             {4,5,6},
                             {7,8,9},
            };

            for (int i = 0, sum = 0; i < 3; i++) {
                sum = 0;
                for (int j = 0; j < 3; j++) {
                    sum+=nums[j,i];
                }
                Console.WriteLine("Сумма " + (i+1) + " столбца: " + sum);
            }
            
        }
    }
}
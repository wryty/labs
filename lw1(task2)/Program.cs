using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int paireqal, pairzero, paireven, pairend5;
            paireqal = pairzero = paireven = pairend5 = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    if (a[i] == a[i + 1]) paireqal++;
                    if (a[i] % 2 == 0 && a[i + 1] % 2 == 0) paireven++;
                    if (Convert.ToString(a[i]) [Convert.ToString(a[i]).Length - 1] == '5' && (Convert.ToString(a[i + 1]) [Convert.ToString(a[i + 1]).Length - 1] == '5') ) pairend5++;
                    continue;
                }
                if (i == a.Length - 1)
                {
                    //if (a[i] == a[i - 1]) paireqal++;
                    //if (a[i] == 0 && a[i - 1] == 0) pairzero++;
                    //if (a[i] % 2 == 0 && a[i - 1] % 2 == 0) paireven++;
                    //if (Convert.ToString(a[i])[Convert.ToString(a[i]).Length - 1] == '5' && (Convert.ToString(a[i + 1]) [Convert.ToString(a[i - 1]).Length - 1] == '5')) pairend5++;
                    break;
                }
                //if (a[i] == a[i - 1]) paireqal++;
                if (a[i] == a[i + 1]) paireqal++;
                if (a[i] == 0 && a[i + 1] == 0) pairzero++;
                //if (a[i] == 0 && a[i - 1] == 0) pairzero++;
                if (a[i] % 2 == 0 && a[i + 1] % 2 == 0) paireven++;
                //if (a[i] % 2 == 0 && a[i - 1] % 2 == 0) paireven++;
                if (Convert.ToString(a[i])[Convert.ToString(a[i]).Length - 1] == '5' && (Convert.ToString(a[i + 1])[Convert.ToString(a[i + 1]).Length - 1] == '5')) pairend5++;
                //if (Convert.ToString(a[i])[Convert.ToString(a[i]).Length - 1] == '5' && (Convert.ToString(a[i - 1])[Convert.ToString(a[i - 1]).Length - 1] == '5')) pairend5++;
            }

            Console.WriteLine("Пар соседей, равных между собой: " + paireqal);
            Console.WriteLine("Пар соседей, равных нулю: " + pairzero);
            Console.WriteLine("Пар чётных соседей: " + paireven);
            Console.WriteLine("Пар соседей, оканчивающихся на 5: " + pairend5);
        }
    }
}
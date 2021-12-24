using System;

namespace Tashoglo3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите х:");
                double x = double.Parse(Console.ReadLine());
                double S = 0;
                for (int i = 0, h=2; i < n; i++, h+=2)
                {
                    long f = 1;
                    for (int j = 1; j <= h; j++) f += j;
                    {
                        if (i % 2 == 0) S += -Math.Pow(x - 1, h) / f;
                        else S += Math.Pow(x - 1, h) / f;
                    }
                }
                Console.WriteLine("S={0:F2}", S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}



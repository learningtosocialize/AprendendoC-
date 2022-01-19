using System;

class Program
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                double d1 = Math.Pow(i, 2);
                Console.WriteLine($"{i}^2 = {d1}");
            }
               
        }

    }

}
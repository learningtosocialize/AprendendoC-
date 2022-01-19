using System;

class DIO
{

    static void Main(string[] args)
    {
        double S = 0;
        
        for (double i = 1; i <= 100; i++)
        {
            double c = 1;
            double a = c / i;
            S = S + a;
        }
        var x = Math.Round(S, 2);
        Console.WriteLine(x);
    }

}
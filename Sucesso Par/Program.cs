using System;

class DIO
{

    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        
        if ((x+1)%2 == 0)
        {
            Console.WriteLine(x+1);
        }
        else
        {
            Console.WriteLine(x+2);
        }
    }

}
using System;

class DIO
{

    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int cont = 0;
        int qnt_esfera = 0;

        if (num1 >= num2)
        {
            while (num2 <= num1)
            {

                for (int i = 1; i < num1 + 1; i++)
                {
                    if (num2 % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont % 2 == 0)
                {
                    qnt_esfera++;
                }
                num2++;
                cont = 0;
            }
            Console.WriteLine(qnt_esfera);
        }

        else
        {
            
            while (num1 <= num2)
            {

                for (int i = 1; i < num2 + 1; i++)
                {
                    if (num1 % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont % 2 == 0)
                {
                    qnt_esfera++;
                }
                num1++;
                cont = 0;
            }
            Console.WriteLine(qnt_esfera);
        }
    }
     
}
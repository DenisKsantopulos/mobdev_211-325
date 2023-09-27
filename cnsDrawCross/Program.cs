using System;

class Program
{
    static void Main()
    {
        do
        {
            Console.Clear();

            Console.Write("Введите высоту креста(четную): ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int k = 0;
            int c = height-1;
            int u = height / 2;
            int v = 0;

            for (int i = 0; i < height; i++)
            {

                if(i<height/2)
                {
                    for (int m = 0; m < k; m++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" \\");
                    for (int m = 0; m < c-1; m++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("/");
                }
                if (i >= height / 2)
                {
                    for (int m = 0; m < u; m++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("/");
                    u--;
                    for (int m = 0; m < v; m++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\\");
                    v+=2;
                }
                Console.WriteLine();
                k++;
                c=c-2;
            }
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Повторить? (y/n): ");
        } while (Console.ReadLine().ToLower() == "y");
    }
}
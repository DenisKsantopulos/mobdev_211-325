using System;

class Program
{
    static void Main()
    {
        do
        {
            Console.Clear();

            Console.Write("Введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());
            
            Console.Write("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Закрасить прямоугольник? (y/n): ");
            bool paint = Console.ReadLine().ToLower() == "y";

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (paint || i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("Повторить? (y/n): ");
        } while (Console.ReadLine().ToLower() == "y");
    }
}
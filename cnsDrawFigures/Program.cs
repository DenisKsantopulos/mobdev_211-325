using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Введите ширину ромба (нечетное число): ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Введите высоту ромба (нечетное число): ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Закрасить ромб? (да/нет): ");
            bool fill = Console.ReadLine().ToLower() == "да";

            DrawRhombus(width, height, fill);

            Console.Write("Повторить? (да/нет): ");
        } while (Console.ReadLine().ToLower() == "да");
    }

    public static void DrawRhombus(int width, int height, bool fill)
    {
        // Проверяем, что ширина и высота нечетные числа
        if (width % 2 == 0 || height % 2 == 0)
        {
            Console.WriteLine("Ошибка: ширина и высота должны быть нечетными числами.");
            return;
        }

        // Вычисляем центр ромба
        int centerX = width / 2;
        int centerY = height / 2;

        // Рисуем ромб
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                // Проверяем, находится ли текущая позиция внутри ромба
                if (Math.Abs(x - centerX) + Math.Abs(y - centerY) <= centerY)
                {
                    if (fill)
                    {
                        Console.Write("*");
                    }
                    else if (x == centerX || y == centerY)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
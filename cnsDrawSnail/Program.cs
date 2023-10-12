using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите ширину улитки: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Введите высоту улитки: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Введите направление рисования (1 - по часовой, -1 - против часовой): ");
        int direction = int.Parse(Console.ReadLine());

        DrawSpiral(width, height, direction);
    }

    static void DrawSpiral(int width, int height, int direction)
    {
        int[,] spiral = new int[height, width];
        int value = 1;
        int left = 0, right = width - 1, top = 0, bottom = height - 1;

        while (left <= right && top <= bottom)
        {
            for (int i = left; i <= right; i++)
            {
                spiral[top, i] = value++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                spiral[i, right] = value++;
            }
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    spiral[bottom, i] = value++;
                }
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    spiral[i, left] = value++;
                }
                left++;
            }
        }

        if (direction == -1)
        {
            int[,] reversedSpiral = new int[height, width];
            for (int i = height - 1; i >= 0; i--)
            {
                for (int j = width - 1; j >= 0; j--)
                {
                    reversedSpiral[height - 1 - i, width - 1 - j] = spiral[i, j];
                }
            }
            spiral = reversedSpiral;
        }

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(spiral[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }
}
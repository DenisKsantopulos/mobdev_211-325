using System;
using System.Collections.Generic;
using GraphShoot;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace GraphShoot
{
    class Circle
    {
        public static void GenerateCircles(Difficulty difficulty, List<CircleShape> circles)
        {
            circles.Clear(); // Очищаем список кругов

            Random random = new Random();
          
            int e = random.Next(2, 4);
            int m = random.Next(3, 5);
            int h = random.Next(3, 5);

            //Генерируем круги в зависимости от выбранной сложности
            switch (difficulty)
            {
                case Difficulty.Easy:
                    for (int i = 0; i < e; i++)
                    {
                        CircleShape circle = new CircleShape(30);
                        circle.Position = new Vector2f(random.Next(300, 700), random.Next(100, 400));
                        circle.FillColor = Color.Blue;
                        circles.Add(circle);
                    }
                    break;
                case Difficulty.Medium:
                    for (int i = 0; i < m; i++)
                    {
                        CircleShape circle = new CircleShape(20);
                        circle.Position = new Vector2f(random.Next(300, 700), random.Next(100, 450));
                        circle.FillColor = new Color((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
                        circles.Add(circle);

                    }

                    break;
                case Difficulty.Hard:
                    for (int i = 0; i < h; i++)
                    {
                        CircleShape circle = new CircleShape(15);
                        circle.Position = new Vector2f(random.Next(300, 700), random.Next(100, 450));
                        circle.FillColor = Color.Red;
                        circles.Add(circle);
                    }
                    break;
            }
        }
    }
}

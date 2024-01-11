using GraphShoot;
using org.mariuszgromada.math.mxparser;
using SFML.Graphics;
using SFML.System;
using SFML.Window;


namespace GraphShoot
{
    class Graph
    {
        private List<CircleShape> circles;

        public Graph(List<CircleShape> circles)
        {
            this.circles = circles;
        }
        public void Draw(RenderWindow window, string userInput)
        {
            Font font = FontManager.GetFont();
            float[] x = new float[800];
            float[] y = new float[800];

            Program program = new Program();
            VertexArray graph = new VertexArray(PrimitiveType.LineStrip, 0); // Используем LineStrip с 0 вершинами
            VertexArray graph2 = new VertexArray(PrimitiveType.LineStrip, 0);
            Color graphColor = Color.Black;
            Button button = new Button("Try again", new Vector2f(505, 495));

            int k = 0;
            //int c = circles.Count;
            bool eg = false;
            List<CircleShape> newCircles = new List<CircleShape>();
            for (int i = 0; i < 800; i++)
            {
                x[i] = (i - 400);
                y[i] = CalculateFunction(x[i], userInput);

                graph.Append(new Vertex(new Vector2f(x[i] + 400, 300 - y[i]), graphColor)); // Добавляем новую вершину к графику

                k = i;
                float r = 0;
                float px = 0;
                float py = 0;
                bool kk = false;
                bool _wall = false;

                for (int j = circles.Count - 1; j >= 0; j--)
                {
                    var circle = circles[j];
                    double distance = Math.Sqrt((x[i] + 400 - circle.Position.X) * (x[i] + 400 - circle.Position.X) + (300 - y[i] - (circle.Position.Y + circle.Radius)) * (300 - y[i] - (circle.Position.Y + circle.Radius)));

                    if (distance <= circle.Radius)// && circle.FillColor!=Color.White)
                    {
                        circles.Remove(circle);
                        r = circle.Radius;
                        py = circle.Position.Y;
                        px = circle.Position.X;
                        CircleShape circle1 = new CircleShape(r);
                        circle1.Position = new Vector2f(px, py);
                        circle1.FillColor = Color.White;
                        circles.Add(circle1);
                        kk = true;
                        break;
                    }
                }
                _wall = program.GetWall();
                if (_wall)
                {
                    //Console.WriteLine($"dst: {545}");
                    bool lose = CheckCollision(x[i] + 400, 300 - y[i]);
                    if (lose)
                    {
                        break;
                    }
                }

                if (kk)
                {
                    eg = true;
                    for (int j = 0; j <= k; j++)
                    {
                        graph2.Append(new Vertex(new Vector2f(x[j] + 400, 300 - y[j]), Color.White));
                    }

                    foreach (var circle1 in circles)
                    {
                        window.Draw(circle1);
                    }
                    window.Draw(graph2);
                    kk = false;

                    //break;
                }

                if (!eg)
                {
                    window.Draw(graph);
                }

                if (button.IsPressed)//"Try again"
                {
                    //graph.Clear();
                    break;
                }

                button.Update(window);
                button.Draw(window);
                window.Display();

                System.Threading.Thread.Sleep(5);
            }
        }

        public bool CheckCollision(float pointX, float pointY)
        {
            RectangleShape rectangle = new RectangleShape(new Vector2f(10, 50));
            rectangle.FillColor = Color.Black;

            RectangleShape rectangle2 = new RectangleShape(new Vector2f(10, 50));
            rectangle2.FillColor = Color.Black;

            rectangle.Position = new Vector2f(250, 330);
            rectangle2.Position = new Vector2f(275, 190);

            FloatRect rectangleBounds = rectangle.GetGlobalBounds();
            FloatRect rectangle2Bounds = rectangle2.GetGlobalBounds();

            if (pointX >= rectangleBounds.Left && pointX <= rectangleBounds.Left + rectangleBounds.Width &&
                pointY >= rectangleBounds.Top && pointY <= rectangleBounds.Top + rectangleBounds.Height)
            {
                return true;
            }

            if (pointX >= rectangle2Bounds.Left && pointX <= rectangle2Bounds.Left + rectangle2Bounds.Width &&
                pointY >= rectangle2Bounds.Top && pointY <= rectangle2Bounds.Top + rectangle2Bounds.Height)
            {
                return true;
            }

            return false;
        }
        private static float CalculateFunction(float x, string userInput)
        {
            string expression = userInput.Replace("x", x.ToString());
            Expression e = new Expression(expression);
            return (float)e.calculate();
        }
        public void DrawAxes(RenderWindow window)
        {
            // Рисуем ось X
            VertexArray xAxis = new VertexArray(PrimitiveType.Lines, 2);
            xAxis[0] = new Vertex(new Vector2f(0, 300), Color.Red);
            xAxis[1] = new Vertex(new Vector2f(800, 300), Color.Red);

            for (int x = 50; x <= 750; x += 50)
            {
                VertexArray tick = new VertexArray(PrimitiveType.Lines, 2);
                tick[0] = new Vertex(new Vector2f(x, 295), Color.Red);
                tick[1] = new Vertex(new Vector2f(x, 305), Color.Red);
                window.Draw(tick);
            }

            // Рисуем ось Y
            VertexArray yAxis = new VertexArray(PrimitiveType.Lines, 2);
            yAxis[0] = new Vertex(new Vector2f(400, 0), Color.Blue);
            yAxis[1] = new Vertex(new Vector2f(400, 600), Color.Blue);

            for (int y = 50; y <= 550; y += 50)
            {
                VertexArray tick = new VertexArray(PrimitiveType.Lines, 2);
                tick[0] = new Vertex(new Vector2f(395, y), Color.Blue);
                tick[1] = new Vertex(new Vector2f(405, y), Color.Blue);
                window.Draw(tick);
            }

            window.Draw(xAxis);
            window.Draw(yAxis);
        }
    }
}
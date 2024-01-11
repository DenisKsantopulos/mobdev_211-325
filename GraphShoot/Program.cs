using System;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using GraphShoot;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace GraphShoot
{
    class Program
    {
        static bool wall = false;
        public bool GetWall()
        {
            return wall;
        }
        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode(800, 600), "Circle Game");

            // Создаем шрифт для текста
            Font font = FontManager.GetFont();
            Random random = new Random();

            // Создаем текст для отображения инструкций
            Text instructionText = new Text("Выберите сложность: Легкая (L), Норм (N) или Сложная (S). \nДобавить(W) или убрать(D) препятствия", font, 20);
            instructionText.Position = new Vector2f(50, 30);
            instructionText.FillColor = Color.Black;
            Text funcText = new Text("Впишите функцию y =", font, 20);
            funcText.Position = new Vector2f(20, 450);
            funcText.FillColor = Color.Black;

            // Создаем текст для отображения выбранной сложности
            Text difficultyText = new Text("", font, 20);
            difficultyText.Position = new Vector2f(50, 80);
            difficultyText.FillColor = Color.Black;


            // Устанавливаем начальное значение сложности
            Difficulty difficulty = Difficulty.Easy;

            window.Clear(Color.White);
            window.Draw(instructionText);
            window.Draw(difficultyText);
            window.Display();

            bool IsActive = false;

            // Создаем список для хранения кругов
            List<CircleShape> circles = new List<CircleShape>();
            Circle.GenerateCircles(difficulty, circles);

            Textbox textbox = new Textbox();
            TextField textField = new TextField();
            Button button = new Button("Go Graph", new Vector2f(400, 495));
            Graph graph = new Graph(circles);

            var backgroundRectangle = new RectangleShape(new Vector2f(800, 600))
            {
                FillColor = Color.White
            };
            window.Draw(backgroundRectangle);

            RectangleShape rectangle = new RectangleShape(new Vector2f(10, 50));
            rectangle.FillColor = Color.Black;

            RectangleShape rectangle2 = new RectangleShape(new Vector2f(10, 50));
            rectangle2.FillColor = Color.Black;

            rectangle.Position = new Vector2f(-100, -100);
            rectangle2.Position = new Vector2f(-100, -100);

            string userInput1 = "";

            // Основной цикл приложения
            while (window.IsOpen)
            {
                window.DispatchEvents();
                button.Update(window);
                button.Draw(window);
                graph.DrawAxes(window);
 
                if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
                {
                    Circle.GenerateCircles(difficulty, circles);
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.W))
                {
                    rectangle.Position = new Vector2f(250, 330);
                    rectangle2.Position = new Vector2f(275, 190);

                    wall = true;
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.D))
                {
                    rectangle.Position = new Vector2f(-100, -100);
                    rectangle2.Position = new Vector2f(-100, -100);

                    wall = false;
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.L))
                {
                    window.Clear(Color.White);

                    difficulty = Difficulty.Easy;
                    difficultyText.DisplayedString = "Выбрана легкая сложность";
                    foreach (var circle in circles)
                    {
                        circle.Draw(window, RenderStates.Default);

                    }
                    window.Draw(rectangle);
                    window.Draw(rectangle2);
                    window.Draw(instructionText);
                    window.Draw(difficultyText);
                    //window.Display();

                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.N))
                {
                    window.Clear(Color.White);
                    difficulty = Difficulty.Medium;
                    difficultyText.DisplayedString = "Выбрана нормальная сложность";
                    foreach (var circle in circles)
                    {
                        window.Draw(circle);
                    }
                    window.Draw(rectangle);
                    window.Draw(rectangle2);
                    window.Draw(instructionText);
                    window.Draw(difficultyText);
                    //window.Display();
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.S))
                {
                    window.Clear(Color.White);
                    difficulty = Difficulty.Hard;
                    difficultyText.DisplayedString = "Выбрана сложная сложность";
                    foreach (var circle in circles)
                    {
                        window.Draw(circle);
                    }
                    window.Draw(rectangle);
                    window.Draw(rectangle2);
                    window.Draw(instructionText);
                    window.Draw(difficultyText);
                    //window.Display();
                }

                if (Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    Vector2i mousePos = Mouse.GetPosition(window);
                    if (textField.CheckMouseClick(mousePos))
                    {
                        textField.SetActive(true);
                        IsActive = true;
                    }
                    else
                    {
                        textField.SetActive(false);
                        IsActive = false;
                    }
                }

                if (button.IsPressed)//"Go Graph"
                {
                    string userInput = textbox.GetUserInput();
                    graph.Draw(window, userInput);

                    button.IsPressed = false;
                }

                window.Draw(funcText);
                textField.Draw(window);

                if (IsActive)
                {
                    string enteredText = textbox.HandleTextEntry(window); // Получаем введенный текст
                    userInput1 += enteredText;
                    IsActive = false;
                    
                }
                window.Display();

                // Отображаем инструкции и выбранную сложность
                window.Draw(instructionText);
                window.Draw(difficultyText);
            }
        }

    }
}

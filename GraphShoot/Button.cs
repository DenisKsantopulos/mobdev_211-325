using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace GraphShoot
{
    class Button
    {
        private RectangleShape shape;
        private Text label;
        private Color idleColor;
        private Color hoverColor;

        public bool IsPressed;

        public Button(string labelText, Vector2f position)
        {
            shape = new RectangleShape(new Vector2f(100, 50));
            shape.Position = position;

            label = new Text(labelText, new Font("arial.ttf"));
            label.CharacterSize = 20;
            label.Position = new Vector2f(position.X + 10, position.Y + 10);

            idleColor = new Color(100, 100, 100);
            hoverColor = new Color(150, 150, 150);

            IsPressed = false;
        }

        public void Update(RenderWindow window)
        {
            if (shape.GetGlobalBounds().Contains(Mouse.GetPosition(window).X, Mouse.GetPosition(window).Y))
            {
                shape.FillColor = hoverColor;
                if (Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    IsPressed = true;
                }
                else
                {
                    IsPressed = false;
                }
            }
            else
            {
                shape.FillColor = idleColor;
                IsPressed = false;
            }
        }

        public void Draw(RenderWindow window)
        {
            window.Draw(shape);
            window.Draw(label);
        }
    }
}

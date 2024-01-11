using System;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace GraphShoot
{
    public class TextField
    {
        private bool isTextFieldActive = false;
        private RectangleShape inputField;

        public TextField()
        {
            inputField = new RectangleShape(new Vector2f(250, 40));
            inputField.Position = new Vector2f(20, 500);
            inputField.FillColor = Color.White;

        }

        public void Draw(RenderWindow window)
        {
            inputField.OutlineColor = isTextFieldActive ? Color.Blue: Color.Black;
            inputField.OutlineThickness = 2;

            window.Draw(inputField);
            //window.Display();
        }

        public bool CheckMouseClick(Vector2i mousePos)
        {
            return inputField.GetGlobalBounds().Contains(mousePos.X, mousePos.Y);
        }

        public void SetActive(bool active)
        {
            isTextFieldActive = active;
        }
    }
}

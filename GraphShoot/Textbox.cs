using System;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace GraphShoot
{
    class Textbox
    {
        private string userInput2 = "";
        public string HandleTextEntry(RenderWindow window)
        {
            Font font = FontManager.GetFont();
            
            bool shiftPressed = false;
            string userInput = "";
            string userInput3 = "";

            window.KeyPressed += (sender, e) =>
            {
                if (e.Code == Keyboard.Key.BackSpace && userInput.Length > 0)
                {
                    userInput = userInput.Substring(0, userInput.Length - 1);
                }
                else if (e.Code == Keyboard.Key.LShift || e.Code == Keyboard.Key.RShift)
                {
                    shiftPressed = true;
                }
                else if (e.Code >= Keyboard.Key.A && e.Code <= Keyboard.Key.Z)
                {
                    char character = (char)('a' + e.Code - Keyboard.Key.A);
                    if (shiftPressed)
                    {
                        character = char.ToUpper(character);
                    }
                    userInput += character;
                }
                else if (e.Code >= Keyboard.Key.Num0 && e.Code <= Keyboard.Key.Num9)
                {
                    userInput += (e.Code - Keyboard.Key.Num0).ToString();
                }
                else if (e.Code == Keyboard.Key.Dash)
                {
                    userInput += "-";
                }
                else if (e.Code == Keyboard.Key.Equal)
                {
                    userInput += "+";
                }
                else if (e.Code == Keyboard.Key.Slash)
                {
                    userInput += "/";
                }
                else if (e.Code == Keyboard.Key.LBracket)
                {
                    userInput += "(";
                }
                else if (e.Code == Keyboard.Key.RBracket)
                {
                    userInput += ")";
                }
                else if (e.Code == Keyboard.Key.Comma)
                {
                    userInput += "*";
                }
            };

            window.KeyReleased += (sender, e) =>
            {
                if (e.Code == Keyboard.Key.LShift || e.Code == Keyboard.Key.RShift)
                {
                    shiftPressed = false;
                }
            };

            Button button = new Button("Enter", new Vector2f(295, 495));
            while (window.IsOpen)
            {
                window.DispatchEvents();

                Text userInputText = new Text(userInput, font, 20);
                userInputText.Position = new Vector2f(20, 510);
                userInputText.FillColor = Color.Black;
                window.Draw(userInputText);

                window.Display();

                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                {
                    window.Close();
                }

                if (button.IsPressed)//"Enter"
                {
                    //Console.WriteLine($"User input: {userInput}");
                    button.IsPressed = false;
                    userInput2 = "";
                    userInput2 += userInput;

                    Console.WriteLine($"User input: {userInput2}");
                    userInput = "";
                    return userInput2;
                }

                button.Update(window);
                button.Draw(window);
            }
            return userInput;
        }
        public string GetUserInput()
        {
            return userInput2;
        }
    }
}
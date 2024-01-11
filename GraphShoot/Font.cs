using SFML.Graphics;
using SFML.System;

public class FontManager
{
    private static Font _font;

    public static Font GetFont()
    {
        if (_font == null)
        {
            _font = new Font("arial.ttf"); // Укажите путь к вашему файлу шрифта
        }
        return _font;
    }
}


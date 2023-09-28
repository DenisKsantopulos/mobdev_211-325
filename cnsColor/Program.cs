
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("Green text on red bc");
Console.ResetColor();
Console.WriteLine("common text");

foreach (var color in Enum.GetValues<ConsoleColor>()) 
{
    Console.WriteLine(color);
}

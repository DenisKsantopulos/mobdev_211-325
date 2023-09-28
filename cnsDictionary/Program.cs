
// Dictionary
// Ключ(уникальный) - Значение

Dictionary<int, string> x = new();
x.Add(10, "Oslo");
x.Add(20, "Ottawa");
x.Add(30, "Montreal");
x.Add(40, "Vancouver");

Console.WriteLine(x[30]);
x[10] = "Totonto";
x[99] = "Dublin";

foreach (var item in x)
{
    Console.WriteLine($"key={item.Key}, value={item.Value}");
}
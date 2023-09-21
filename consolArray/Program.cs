// Array

string[] cities = { "Detroit", "Riga", "Madrid", "Beijing" };
Console.WriteLine(cities[0]);
Console.WriteLine(cities[^1]);
Console.WriteLine("...........");

// 1
for  (int i = 0; i < cities.Length; i++)
{
    Console.WriteLine(cities[i]);
}
Console.WriteLine();
Console.WriteLine("..........");

// 2
foreach (string city in cities)
{
    Console.WriteLine(city);
}

// change array lenght

Array.Resize<string>(ref cities, 3);
Console.WriteLine(string.Join(' ',cities));

// empty

string[] m1 = { };
string[] m2 = Array.Empty<string>();

//почитать про индексы и диапозоны
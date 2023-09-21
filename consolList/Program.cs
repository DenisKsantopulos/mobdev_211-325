// List

// (A) Обычный список

using System.Collections;

ArrayList arrayList = new ArrayList();
arrayList.Add(100);
arrayList.Add("hello");
arrayList.Add(3.14);

// (B) Обобщенный список

List<string> cities = new() { "Moscow", "Tokio", "Berlin" };
cities.Add("Warsaw");
cities.AddRange(new string[] { "Paris", "Seattle" });
Console.WriteLine(string.Join(", ", cities));
cities.Sort();
Console.WriteLine(string.Join(", ", cities));
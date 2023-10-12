
// Очередь (Queue)

// Обычная очередь

using System.Collections;

Queue queue = new();
queue.Enqueue(100500);
queue.Enqueue("HI");
queue.Enqueue(3.14);
Console.WriteLine($"look -> {queue.Peek()}");
while (queue.Count > 0) 
{
    Console.WriteLine(queue.Dequeue());
}

// Обобщенная очередь

Queue<int> numbers = new();
numbers.Enqueue(1);
numbers.Enqueue(2);
numbers.Enqueue(3);
numbers.Enqueue(4);
Console.WriteLine($"look -> {numbers.Peek()}");
Console.WriteLine($"Sum -> {numbers.Sum()}");
while (numbers.Count > 0)
{
    Console.WriteLine(numbers.Dequeue());
}
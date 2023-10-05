namespace cnsOOPStudent
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Student x = new();
            x.AgeCreated += X_AgeCreated;
            x.AgeCreatedInt += X_AgeCreatedInt;
            x.Name="Ivan";
            x.Surname="Petrov";
            x.Age = 19;
            Console.WriteLine(x.GetFullName());
            x.Age = -3;
            Console.WriteLine(x.GetFullName());

            Student x2 = new();
            x2.Name = "Petia";
            x2.Surname = "Ivanov";
            x2.Age = 19;
            x2.AgeCreated += X_AgeCreated;
            
        }

        private static void X_AgeCreatedInt(object? sender, EventArgs e, int new_age)
        {
            Console.WriteLine($"AgeCreatedInt => {new_age}");
        }

        private static void X_AgeCreated(object? sender, EventArgs e)
        {
            if (sender is Student student)
            {
                Console.WriteLine("Age was changed" + $" new age is {student.Age}");
            }
        }
    }
}
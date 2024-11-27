using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        // Завдання 1
        Console.WriteLine("Завдання 1:");
        Console.Write("Введіть значення x: ");
        double inputX = double.Parse(Console.ReadLine());

        Func<double, double> F = (x) => x > 0 ? Math.Sin(2 * x) : 1 - 2 * Math.Sin(2 * x);

        double result = F(inputX);
        Console.WriteLine($"F({inputX}) = {result}");
        Console.WriteLine();

        //Завдання 2
        Console.WriteLine("Завдання 2:");
        Console.Write("Введіть першу країну: ");
        string country1 = Console.ReadLine();
        Console.Write("Введіть другу країну: ");
        string country2 = Console.ReadLine();

        Func<string, string, string> longerName = (c1, c2) => c1.Length > c2.Length ? c1 : c2;

        string longer = longerName(country1, country2);
        Console.WriteLine($"Довша назва: {longer} (довжина: {longer.Length})");
        Console.WriteLine();

        //Завдання 3
        Console.WriteLine("Завдання 3:");
        Console.Write("Введіть число: ");
        int number = int.Parse(Console.ReadLine());

        Predicate<int> isPositive = (n) => n > 0;

       
        if (isPositive(number))
        {
            Console.WriteLine("Число додатнє.");
        }
        else
        {
            Console.WriteLine("Число не є додатнім.");
        }
    }
}

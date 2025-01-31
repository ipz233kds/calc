using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Простий калькулятор");

        Console.Write("Введіть перше число: ");
        string num1Str = Console.ReadLine();
        double num1 = Convert.ToDouble(num1Str);

        Console.Write("Введіть друге число: ");
        string num2Str = Console.ReadLine();
        double num2 = Convert.ToDouble(num2Str);

        Console.Write("Оберіть операцію (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = Calculate(num1, num2, operation);
        Console.WriteLine($"Результат: {result}");
    }

    static double Calculate(double a, double b, char op)
    {
        double result = 0;

        if (op == '+')
        {
            result = a + b;
        }
        else if (op == '-')
        {
            result = a - b;
        }
        else if (op == '*')
        {
            result = a * b;
        }
        else if (op == '/')
        {
            if (b != 0)
                result = a / b;
            else
                Console.WriteLine("Помилка: Ділення на нуль!");
        }
        else
        {
            Console.WriteLine("Невідома операція!");
        }

        return result;
    }
}

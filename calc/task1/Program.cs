﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Простий калькулятор");

        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Оберіть операцію (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = Calculate(num1, num2, operation);
        Console.WriteLine($"Результат: {result}");
    }

    static double Calculate(double a, double b, char op)
    {
        return op switch
        {
            '+' => Add(a, b),
            '-' => Subtract(a, b),
            '*' => Multiply(a, b),
            '/' => Divide(a, b),
            _ => throw new ArgumentException("Невідома операція!")
        };
    }
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;

    static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Помилка: Ділення на нуль!");
        return a / b;
    }
}

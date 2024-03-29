﻿using System.Diagnostics.Metrics;
using System.Transactions;

while (true)
{
    Console.WriteLine("Input first value: ");
    if (!Double.TryParse(Console.ReadLine(), out double leftValue))
    {
        Console.WriteLine("Incorrect first value. Try again");
        continue;
    }

secondStep: Console.WriteLine("Input sign: '+', '-', '*', '/'");
    char sign = Console.ReadKey().KeyChar;
    if (sign != '+' && sign != '-' && sign != '*' && sign != '/')
    {
        Console.WriteLine("Incorrect sign. Try again");
        goto secondStep;
    }


    Console.WriteLine();
thirdStep: Console.WriteLine("Input second value: ");
    if (!Double.TryParse(Console.ReadLine(), out double rightValue))
    {
        Console.WriteLine("Incorrect second value. Try again");
        goto thirdStep;
    }

    double result = 0;
    switch (sign)
    {
        case '+':
            Console.WriteLine($"Result = {result = leftValue + rightValue}"); break;
        case '-':
            Console.WriteLine($"Result = {result = leftValue - rightValue}"); break;
        case '*':
            Console.WriteLine($"Result = {result = leftValue * rightValue}"); break;
        case '/':
            {
                if (rightValue == 0)
                    Console.WriteLine("Division by 0 is not possible. Try again");
                else Console.WriteLine($"Result = {result = leftValue / rightValue}"); break;
            }
        default:
            break;
    }

    Console.WriteLine("To repeat, enter the enter key. If you want to go out enter 'quit'");
    if (Console.ReadLine() == "quit")
        return;
}
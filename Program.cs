using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Type 'exit' at any time to quit.\n");

        while (true)
        {
            string input = GetRawInput("Enter first number or 'exit': ");
            if (IsExit(input)) break;
            double num1 = ParseDouble(input);

            string op = GetOperator();
            if (IsExit(op)) break;

            input = GetRawInput("Enter second number or 'exit': ");
            if (IsExit(input)) break;
            double num2 = ParseDouble(input);

            double? result = Calculate(num1, num2, op);

            if (result != null)
            {
                Console.WriteLine("Result: " + result + "\n");
            }
        }

        Console.WriteLine("Goodbye!");
    }

    static string GetRawInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    static bool IsExit(string input)
    {
        return input.Trim().ToLower() == "exit";
    }

    static double ParseDouble(string input)
    {
        while (true)
        {
            try
            {
                return Convert.ToDouble(input);
            }
            catch (FormatException)
            {
                Console.Write("Invalid input. Enter a numeric value: ");
                input = Console.ReadLine();
                if (IsExit(input)) Environment.Exit(0);
            }
        }
    }

    static string GetOperator()
    {
        while (true)
        {
            Console.Write("Enter operator (+, -, *, /) or 'exit': ");
            string op = Console.ReadLine();
            if (IsExit(op)) return op;
            if (op == "+" || op == "-" || op == "*" || op == "/")
            {
                return op;
            }
            Console.WriteLine("Invalid operator. Try again.");
        }
    }

    static double? Calculate(double num1, double num2, string op)
    {
        switch (op)
        {
            case "+": return num1 + num2;
            case "-": return num1 - num2;
            case "*": return num1 * num2;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero.");
                    return null;
                }
                return num1 / num2;
            default:
                Console.WriteLine("Unknown operator.");
                return null;
        }
    }
}





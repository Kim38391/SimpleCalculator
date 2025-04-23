using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");

        double num1 = GetNumber("Enter first number: ");
        string op = GetOperator();
        double num2 = GetNumber("Enter second number: ");

        double? result = Calculate(num1, num2, op);

        if (result != null)
        {
            Console.WriteLine("Result: " + result);
        }
    }

    static double GetNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }

    static string GetOperator()
    {
        while (true)
        {
            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();
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



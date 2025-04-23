using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        try
        {
            Console.Write("Enter First number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }
            Console.WriteLine("Result: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number entered. Please enter numeric values.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}


using System;

namespace Calculator 
{
    class Program 
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a Number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an Operator (+, -, *, /, %, sqrt, pow, sin, cos, tan): ");
                string op = Console.ReadLine();

                double num2 = 0;
                if (op != "sqrt" && op != "sin" && op != "cos" && op != "tan")
                {
                    Console.Write("Enter a Number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }

                switch (op)
                {
                    case "+":
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero");
                        }
                        break;
                    case "%":
                        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                        break;
                    case "sqrt":
                        Console.WriteLine($"sqrt({num1}) = {Math.Sqrt(num1)}");
                        break;
                    case "pow":
                        Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");
                        break;
                    case "sin":
                        Console.WriteLine($"sin({num1}) = {Math.Sin(num1)}");
                        break;
                    case "cos":
                        Console.WriteLine($"cos({num1}) = {Math.Cos(num1)}");
                        break;
                    case "tan":
                        Console.WriteLine($"tan({num1}) = {Math.Tan(num1)}");
                        break;
                    default:
                        Console.WriteLine("Invalid Operator, please select from '+', '-', '*', '/', '%', 'sqrt', 'pow', 'sin', 'cos', 'tan'");
                        break;
                }

                Console.WriteLine("Do you want to perform another calculation? (yes to continue, any other key to exit)");
                string continueCalc = Console.ReadLine().ToLower();
                if (continueCalc != "yes")
                {
                    break;
                }
            }
        }
    }
}


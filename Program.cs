using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char operation;
            bool exit = false;
            do
            {
                Console.WriteLine("Enter your first number");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your second number");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the operation (+,-,*,/,%):)");
                operation = char.Parse(Console.ReadLine());
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine(result);
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine(result);
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine(result);
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("it can not be possible please chose another number.");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine(result);
                        }
                        break;
                    case '%':
                        result = num1 % num2;
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine(" ınvalid operation !");
                        break;
                }
                Console.Write("Do you want to continue? (yes/no) ");
                string choice = Console.ReadLine().ToLower();
                if (choice != "yes")
                {
                    exit = true;
                }
            } while (!exit);

            Console.WriteLine("Exiting calculator...");
            Console.ReadLine();
        }
    }
}


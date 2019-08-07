using System;

namespace Week_3_Math_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;
            int num1;
            int num2;
            int answer;

            Console.WriteLine("Select an opertion from below: ");
            Console.WriteLine("\t+ = add");
            Console.WriteLine("\t- = subtract");
            Console.WriteLine("\t/ = divide");
            Console.WriteLine("\t* = multiply");
            Console.WriteLine("\tE = Exit");
            operation = Console.ReadLine();

            Console.Write("Enter number one: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number two: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Not a valid choice. Input a number in place of zero!");
                Console.Write("Enter number two: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                answer = num1 / num2;
                Console.WriteLine($"The answer is: " + answer);
                Console.ReadLine();
            }

            if (operation == "+")
            {
                answer = num1 + num2;
                Console.WriteLine($"The answer is: " + answer);
            }
            else if (operation == "-")
            {
                answer = num1 - num2;
                Console.WriteLine($"The answer is: " + answer);
            }
            else if (operation == "/")
            {
                answer = num1 / num2;
                Console.WriteLine($"The answer is: " + answer);
            }
            else if (operation == "*")
            {
                answer = num1 * num2;
                Console.WriteLine($"The answer is: " + answer);
            }
            else
            {
                Console.WriteLine("Thanks for stopping by!");
            }
            Console.ReadLine();
        }
    }
}

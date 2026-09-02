using System;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO MY CALCULATOR PROGRAM!");
            int choice = 0;
            while(choice != 5)
            {
                PrintMenu();
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice, please enter again!");
                    continue;
                }
                
                if(choice == 5)
                {
                    Console.WriteLine("Exit Program!");
                    continue;
                }
                Console.Write("Enter your first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Add result: {a} + {b} = {Add(a, b)}");
                        break;
                    case 2:
                        Console.WriteLine($"Subtract result: {a} - {b} = {Subtract(a, b)}");
                        break;
                    case 3:        
                        Console.WriteLine($"Multiply result: {a} * {b} = {Multiply(a, b)}");
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine($"Divide result: {a} / {b} = {Divide(a, b)}");
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    default:
                        Console.WriteLine("Your choice isn't menu, please enter again!");
                        break;
                }
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("Calculator's menu: ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Divide(int a, int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException();
            }
            return a/b;
        }
    }
}
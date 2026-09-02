using System;
using System.Diagnostics;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices.Marshalling;

namespace NumberAnalyzerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NUMBER ANALYZER PROGAM:");
            int n = 0;
            while (true)
            {
                Console.Write("Please enter the number of elements: ");
                if(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Invalid value for n, please try again!");
                    continue;
                }
                break;
            }
            int[] arr = new int[n];
            Console.WriteLine("Input: ");
            for(int i = 0; i < n; ++i)
            {
                while (true)
                {
                    Console.Write($"Element arr[{i}]: ");
                    if(!int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        Console.WriteLine("Invalid value for element, please try again!");
                        continue;
                    }
                    break;
                }
            }
            Console.WriteLine("The array you have entered: ");
            for(int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Max: {Max(arr)}");
            Console.WriteLine($"Min: {Min(arr)}");
            Console.WriteLine($"Sum: {Sum(arr)}");
            Console.WriteLine($"Average: {Average(arr)}");
            Console.Write("Even: ");
            int[] even = Even(arr);
            foreach (int item in even)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Odd: ");
            int[] odd = Odd(arr);
            foreach (int item in odd)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Prime: ");
            int[] prime = Prime(arr);
            foreach (int item in prime)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static int Max(int[] arr)
        {
            int max = int.MinValue;
            foreach(int item in arr)
            {
                if(item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        static int Min(int[] arr)
        {
            int min = int.MaxValue;
            foreach(int item in arr)
            {
                if(item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        static int Sum(int[] arr)
        {
            int sum = 0;
            foreach(int item in arr)
            {
                sum += item;
            }
            return sum;
        }
        static double Average(int[] arr)
        {
            int sum = Sum(arr);
            return (double)sum/arr.Length;
        }
        static int[] Even(int[] arr)
        {
            List<int> even= new List<int>();
            foreach(int item in arr)
            {
                if(item % 2 == 0)
                {
                    even.Add(item);
                }
            }
            return even.ToArray();
        }
        static int[] Odd(int[] arr)
        {
            List<int> odd= new List<int>();
            foreach(int item in arr)
            {
                if(item % 2 != 0)
                {
                    odd.Add(item);
                }
            }
            return odd.ToArray();
        }
        static int[] Prime(int[] arr)
        {
            List<int> prime = new List<int>();
            foreach(int item in arr)
            {
                if (IsPrime(item))
                {
                    prime.Add(item);
                }
            }
            return prime.ToArray();
        }
        static bool IsPrime(int n)
        {
            if(n < 2)
            {
                return false;
            }
            if(n == 2 || n == 3)
            {
                return true;
            }
            if(n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for(int i = 5; i * i <= n; i+= 6)
            {
                if(n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
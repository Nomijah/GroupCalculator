﻿namespace GroupCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int randomNumber = rng.Next(1,101);
            Console.WriteLine(randomNumber);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
      
        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}

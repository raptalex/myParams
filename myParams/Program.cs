// Alexander Raptis, Feb 7th 2023

using System;

namespace myParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            Console.WriteLine("How many random numbers do you want?");
            uint amt = uint.Parse(Console.ReadLine());

            int[] numbers = new int[amt];

            for(uint i=0;i < amt;i++)
                numbers[i] = generator.Next(1, 10);

            Console.Write("Here are your numbers: ");
            foreach (int num in numbers)
                Console.Write($"{num} ");
            Console.WriteLine();

            Console.WriteLine($"all {amt} numbers added together is: {Add(numbers)}");
            Console.WriteLine($"all {amt} numbers multiplied together is: {Multiply(numbers)}");
        }
        static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
                total += num;

            return total;
        }
        static int Multiply(params int[] numbers)
        {
            int total = 1;
            foreach (int num in numbers)
                total *= num;

            return total;
        }
    }
}
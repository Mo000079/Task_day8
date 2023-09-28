using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello There!");
            var nums = new List<int> { 12,1,5, 2, 3,89, 4, 5, 0, 6, 7,11, 8, 19, 10 };

            int fNum = nums.First();
            int gNum = nums.Last();
            Console.WriteLine($"First Number In List : {fNum}");
            Console.WriteLine($"Last Number In List : {gNum}");

            IEnumerable<int> filteredNumbers = nums.Where(n => n > 3);

            Console.WriteLine("Filtered Numbers umbers Greater Than 3:");
            
            foreach (int number in filteredNumbers)
            {
                Console.Write($"{number} , ");
            }
            
            Console.WriteLine();

            IEnumerable<int> takenNumbers = nums.Take(3);
            
            Console.WriteLine($"Taken First 3 Numbers :");
            
            foreach (int number in takenNumbers)
            {
                Console.Write($"{number} , ");
            }
            Console.WriteLine();

            Console.WriteLine($"Ordered List ::");

            IEnumerable<int> orDNums = nums.OrderBy(n => n);
            
            foreach(int number in orDNums)
            {
                Console.Write($"{number} , ");
            }
            Console.WriteLine();







            var oddNumbers = nums.Where(n => n % 2 != 0);


           
            Console.WriteLine("Odd Number :");

            foreach (int number in oddNumbers)
            {
                Console.Write($"{number} , ");
            }
            Console.WriteLine();

            var evenNums = nums.Where(n => n % 2 == 0);
            
            Console.WriteLine("Even Number :");

            foreach (int number in evenNums)
            {
                Console.Write($"{number} , ");
            }
            Console.WriteLine();

            

            
            var evenNumbers = nums.Where(n => n % 2 == 0).Take(3);
            Console.WriteLine($"Take With Where (First 3 Even Numbers) : :"); 
            foreach (int number in evenNumbers)
            {
                Console.Write($"{number} , ");
            }





        }
    }
}
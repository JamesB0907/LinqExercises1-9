using System;
using System.Collections.Generic;
using System.Linq;

public class Customer
{
    public string? Name { get; set; }
    public double Balance { get; set; }
    public string? Bank { get; set; }
}
class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Console.WriteLine();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
            Exercise6();
            Exercise7();
            Exercise8();
            Exercise9();
        }

        static void Exercise1()
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit.StartsWith("L")
                                          select fruit;

            Console.WriteLine("Exercise 1:");
            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }
        }

        static void Exercise2()
        {
            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);

            Console.WriteLine("Exercise 2:");
            foreach (int number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }
        }

        static void Exercise3()
        {
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

            List<string> descend = names.OrderByDescending(n => n).ToList();
            Console.WriteLine("Exercise 3:");
            foreach (string name in descend)
            {
                Console.WriteLine(name);
            }
        }
        static void Exercise4()
        {
            // Build a collection of these numbers sorted in ascending order
            List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};
            List<int> ascendingNumbers = numbers.OrderBy(n => n).ToList();
            Console.WriteLine("Exercise 4:");
            foreach (int number in ascendingNumbers)
            {
                Console.WriteLine(number);
            }
        }
        static void Exercise5()
        {
            // Output how many numbers are in this list
            List<int> numbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

            int numLength = numbers.Count;
            Console.WriteLine("Exercise 5:");
            Console.WriteLine(numLength);
        }
        static void Exercise6()
        {
            // How much money have we made?
            List<double> purchases = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };
            double sum = purchases.Sum();
            Console.WriteLine("Exercise 6:");
            Console.WriteLine(sum.ToString(".##"));
        }
        static void Exercise7()
        {
            // What is our most expensive product?
            List<double> prices = new List<double>()
        {
            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };
            double maxNum = prices.Max();
            Console.WriteLine("Exercise 7:");
            Console.WriteLine(maxNum);
        }
        static void Exercise8()
        {
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            List<int> result = new List<int>();
            foreach (int number in wheresSquaredo)
            {
                double sqrt = Math.Sqrt(number);
                if (sqrt % 1 == 0)
                {
                    break;
                }
                result.Add(number);
            }
            Console.WriteLine("Exercise 8:");
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }

            /*
                Store each number in the following List until a perfect square
                is detected.

                Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
        }
        static void Exercise9()
    {
        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

        var millionairePerBank = customers.Where(c => c.Balance >= 1000000)
                                          .GroupBy(c => c.Bank)
                                          .Select(g => new { Bank = g.Key, Count = g.Count() });

        Console.WriteLine("Exercise 9:");
        foreach (var item in millionairePerBank)
        {
            Console.WriteLine($"{item.Bank} {item.Count}");
        }
    }
}
    

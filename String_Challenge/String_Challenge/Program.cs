using System;

namespace String_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine($"Hello there {name}");
            Console.WriteLine($"Hello there {name.ToLower()}");
            Console.WriteLine($"Hello there {name.ToUpper()}");
            Console.WriteLine($"Hello there {name.Trim()}");
            Console.WriteLine($"Hello there {name.Substring(0,5)}");
            Console.Read();
        }
    }
}

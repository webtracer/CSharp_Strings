using System;

namespace String_Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString;
            char searchChar;
            
            Console.Write("Please enter any string: ");
            userString = Console.ReadLine();
            Console.WriteLine("Please enter a character to find in your string: ");
            searchChar = Console.ReadLine()[0];

            int searchingChar = userString.IndexOf(searchChar);
            Console.WriteLine($"The index of character {searchChar} in your string is {searchingChar}");

            Console.Write("Enter your first name: ");
            string fname = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lname = Console.ReadLine();
            string fullName = string.Concat(fname," ", lname);
            Console.WriteLine($"Your full name is {fullName}");
        }
    }
}

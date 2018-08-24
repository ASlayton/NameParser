using System;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name.");
            var firstName = Console.ReadLine();

            foreach (var letter in firstName)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("Enter your last name.");
            var lastName = Console.ReadLine();
            var lastNameWithSpaces = "";
            //var x = null ?? (bool?)true;

            foreach (var letter in lastName.ToUpper())
            {
                lastNameWithSpaces += letter + " ";
                //Console.Write(letter + " ");
            }
            Console.WriteLine(lastNameWithSpaces.Trim());
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();
            var middleName = "";
            if (hasMiddleName == "y")
            {
                Console.WriteLine("What is your middle name?");
                middleName = Console.ReadLine();
                int i = 0;
                foreach (var letter in middleName)
                {
                    Console.WriteLine(letter.ToString().PadLeft(++i));
                }
            }
            else
            {
                Console.WriteLine($@"{firstName}That sucks.This is the continuation of a really long line just to prove something right now.");
            }



            Console.WriteLine($"Goodbye {firstName} {middleName} {lastName}. Press enter to exist.");
            Console.ReadLine();
        }
    }
}

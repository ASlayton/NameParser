using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class FirstName
    {
        private string _firstName;

        public void GetName() {
            Console.WriteLine("Enter your first name.");
            _firstName = Console.ReadLine();
        }

        public void PrintFirstName() {
            foreach (var letter in _firstName)
            {
                Console.WriteLine(letter);
            }
        }
    }
}

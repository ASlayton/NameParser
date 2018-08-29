using System;

namespace NameParser.Names
{
    class MiddleName
    { 
        private readonly FirstName _firstName;
    
        public string Name { get; private set; }
        
        //Constructor
        // - has no return type
        public MiddleName(FirstName firstName)
        {
            Name = "";
            _firstName = firstName;
        }

        public void GetName()
        {
            if (ConfirmMiddleName())
            {
                Console.WriteLine("What is your middle name?");
                Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($@"Golly Gee, {_firstName.Name}, that sucks.");
            }
        }

        bool ConfirmMiddleName()
        {
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }
        public void PrintName()
        {
            var i = 0;
            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }
    }
}

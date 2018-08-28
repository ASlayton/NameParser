using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class LastName
    {
        public string Name { get; private set; }

        public void GetName()
        {
            
            Console.WriteLine("Enter your Last Name");
            Name = Console.ReadLine();
        }

        public void PrintName()
        { 
            var lastNameWithSpaces = "";
            //var x = null ?? (bool?)true;

            foreach (var letter in Name.ToUpper())
            {
                lastNameWithSpaces += letter + " ";
                //Console.Write(letter + " ");
            }
            Console.WriteLine(lastNameWithSpaces.Trim());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class LastName : NameBase
    {
        public LastName() : base("last")
        {
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

using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    abstract class NameBase
    {
        protected readonly string _whichName;

        public string Name { get; protected set; }
        public string WhichName { get; }

        public NameBase(string whichName)
        {
            _whichName = whichName;
        }

        public virtual void GetName()
        {
            Console.WriteLine($"What is your {_whichName} name");
            Name = Console.ReadLine();
        }

        public abstract void PrintName();
    }
}

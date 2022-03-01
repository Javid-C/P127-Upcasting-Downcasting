using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Upcasting_Downcasting
{
    class Human
    {
        public string Name;

        public virtual void Info()
        {
            Console.WriteLine(Name);
        }
    }
}
